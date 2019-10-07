
console.log("congratulations! you made it ...");
//onLoad = "jsUpdate()";

//var debug = document.getElementById("DebugTools").value;
var debug = true;

// ------------------------------------------
//    variables (global)
// ------------------------------------------

// canvas - used to draw the rectangle (rubber band)
var canvas = null;
var context = null;

// top(x) left(y) positions of the canvas relative to the screen
var canvas_x = null;
var canvas_y = null;

// last positions of the mousedown event, used to draw the rectangle
var last_mouse_x_position = 0;
var last_mouse_y_position = 0;

// trigger used in the mousemove event to know if we need to draw the rectangle
var mousedown = false;

// basic mouse position on mousemove event
var mouse_x = 0;
var mouse_y = 0;
var mouse_z = 0;

// size of the rubberband/rectangle
var rubberband_x = 0;
var rubberband_y = 0;

var draw_crosshairs = debug;
var draw_messages = debug;

function LoadCamera(id) {
    console.log(id);
    document.getElementById("stream").src = "/images/synapse-camera-loading.png";

    $.ajax({
        url: "Camera/LoadCamera",
        type: "POST",
        async: true,
        data: $.param({ cameraId: id }),
        contentType: "application/x-www-form-urlencoded; charset=utf-8",
        success: function (result) {
            var values = Object.values(result);
            console.log(values);

            camerax = values[1]["canvasWidth"];
            cameray = values[1]["canvasHeight"];

            document.getElementById("stream").src = values[1]["cameraStream"];
            document.getElementById("oWrapper").width = values[1]["canvasWidth"];
            document.getElementById("oWrapper").width = values[1]["canvasWidth"];
            document.getElementById("canvas").width = values[1]["canvasWidth"];
            document.getElementById("stream").width = values[1]["canvasWidth"];
            document.getElementById("iWrapper").height = values[1]["canvasHeight"];
            document.getElementById("iWrapper").height = values[1]["canvasHeight"];
            document.getElementById("canvas").height = values[1]["canvasHeight"];
            document.getElementById("stream").height = values[1]["canvasHeight"];

        },
        error: function (result) {
            console.log(result);

        }
    });
    ReloadCanvasSize();
}

function ReloadCanvasSize() {

    // canvas - used to draw the rectangle (rubber band)
    canvas = document.getElementById("canvas");
    context = canvas.getContext("2d");

    // top(x) left(y) positions of the canvas relative to the screen
    canvas_x = $(canvas).offset().left - $(window).scrollLeft();
    canvas_y = $(canvas).offset().top - $(window).scrollTop();

}

$(document).ready(function () {

    ReloadCanvasSize();
    LoadCamera(0);
    DrawCrossHairs();
    SetDefaultPosition();

    // ------------------------------------------
    //    events
    // ------------------------------------------

    // key press event
    $(document).keypress(function (event) {

        var key = event.keyCode ? event.keyCode : event.which;
        console.log("key press: " + key);

        var data;
        switch (key) {

            case 32: // space bar
                SetDefaultPosition();
                break;

            case 43: // (+) on keypad
                ZoomIn();
                break;

            case 45: // (-) on keypad
                ZoomOut();
                break;

            case 49: // (1) on keypad
                data = $.param({ Action: "move", Speed: 100, Value: "downleft" });
                ExecuteNonQueryCommand(data, "Camera/MoveInDirection");
                break;

            case 50: // (2) on keypad
                data = $.param({ Action: "move", Speed: 100, Value: "down" });
                ExecuteNonQueryCommand(data, "Camera/MoveInDirection");
                break;

            case 51: // (3) on keypad
                data = $.param({ Action: "move", Speed: 100, Value: "downright" });
                ExecuteNonQueryCommand(data, "Camera/MoveInDirection");
                break;

            case 52: // (4) on keypad
                data = $.param({ Action: "move", Speed: 100, Value: "left" });
                ExecuteNonQueryCommand(data, "Camera/MoveInDirection");
                break;

            case 53: // (5) on keypad
                SetDefaultPosition();
                break;

            case 54: // (6) on keypad
                data = $.param({ Action: "move", Speed: 100, Value: "right" });
                ExecuteNonQueryCommand(data, "Camera/MoveInDirection");
                break;

            case 55: // (7) on keypad
                data = $.param({ Action: "move", Speed: 100, Value: "upleft" });
                ExecuteNonQueryCommand(data, "Camera/MoveInDirection");
                break;

            case 56: // (8) on keypad
                data = $.param({ Action: "move", Speed: 100, Value: "up" });
                ExecuteNonQueryCommand(data, "Camera/MoveInDirection");
                break;

            case 57: // (9) on keypad
                data = $.param({ Action: "move", Speed: 100, Value: "upright" });
                ExecuteNonQueryCommand(data, "Camera/MoveInDirection");
                break;

            case 68: // (d) on keyboard
                draw_messages = !draw_messages;
                break;

            case 115: // (s) on keyboard
                ZoomOut();
                break;

            case 119: // (w) on keyboard          
                ZoomIn();
                break;
        }
    });

    document.getElementById("canvas").addEventListener("wheel", function (e) {
        if (e.deltaY < 0) {
            ZoomIn();
        }
        if (e.deltaY > 0) {
            ZoomOut();
        }
    });

    // mousedown event
    $(canvas).on("mousedown", function (e) {
        //console.log("mousedown");

        // top(x) left(y) positions of the canvas relative to the screen 
        canvas_x = $(canvas).offset().left - $(window).scrollLeft();
        canvas_y = $(canvas).offset().top - $(window).scrollTop();

        // last positions of the mousedown event, used to draw the rectangle
        last_mouse_x_position = parseInt(e.clientX - canvas_x);
        last_mouse_y_position = parseInt(e.clientY - canvas_y);

        // size of the rectangle 
        rubberband_x = 0;
        rubberband_y = 0;

        // trigger used in the mousemove event to know if we need to draw the rectangle
        mousedown = true;
    });

    // mousemove event
    $(canvas).on("mousemove", function (e) {
        //console.log("mousemove");

        // basic mouse position on mousemove event
        mouse_x = parseInt(e.clientX - canvas_x);
        mouse_y = parseInt(e.clientY - canvas_y);

        // draw rectangle process
        if (mousedown) {
            // size of the rectangle
            rubberband_x = mouse_x - last_mouse_x_position;
            rubberband_y = mouse_y - last_mouse_y_position;

            // draw
            context.clearRect(0, 0, canvas.width, canvas.height);
            context.beginPath();
            context.rect(last_mouse_x_position, last_mouse_y_position, rubberband_x, rubberband_y);
            context.rect((last_mouse_x_position + (rubberband_x / 2) - 2.5), (last_mouse_y_position + (rubberband_y / 2) - 2.5), 5, 5);
            context.strokeStyle = "yellow";
            context.lineWidth = 1;
            context.stroke();

            DrawCrossHairs();
        }
        // calculate the percentage of zoom level
        mouse_z = Math.floor(Math.max((rubberband_x / canvas.width) * 100, (rubberband_y / canvas.height) * 100), 2);
        DrawMessage("Canvas [ X: " + canvas.width + " Y: " + canvas.height + " ] Mouse [ X: " + mouse_x + " | Y: " + mouse_y + " | Z: " + mouse_z + " ]");
    });

    // mouseup event
    $(canvas).on("mouseup", function (e) {
        //console.log("mouseup");

        // trigger used in the mousemove event to know if we need to draw the rectangle
        mousedown = false;

        // clear the canvas
        context.clearRect(0, 0, canvas.width, canvas.height);

        // calculate the center of the drawn rectangle
        var x = (Math.floor(last_mouse_x_position + (rubberband_x / 2)));
        var y = (Math.floor(last_mouse_y_position + (rubberband_y / 2)));

        // only zoom if the rectangle is big enough, otherwise just center the view to the spot clicked
        if (Math.min(rubberband_x, rubberband_y) >= 10) {
            ExecuteNonQueryCommand($.param({ X: x, Y: y, Z: mouse_z }), "Camera/ZoomToPosition");

        } else {
            ExecuteNonQueryCommand($.param({ X: x, Y: y }), "Camera/CenterOnPosition");
        }

        DrawCrossHairs();

    });

    // ------------------------------------------
    //    functions (UI)
    // ------------------------------------------

    function DrawCrossHairs() {

        // draw rectangle process
        if (draw_crosshairs) {

            var w = canvas.width;
            var h = canvas.height;

            // setup 
            context.beginPath();
            context.strokeStyle = "limegreen";
            context.lineWidth = 1;

            // draw line on the x
            context.moveTo(0, h / 2);
            context.lineTo(w, h / 2);

            // draw line on the y
            context.moveTo(w / 2, 0);
            context.lineTo(w / 2, h);

            // commit
            context.stroke();
        }
    }

    function DrawMessage(msg) {

        if (draw_messages) {

            context.fillStyle = "white";
            context.clearRect(10, 10, 300, 15);
            context.fillRect(10, 10, 300, 15);
            context.strokeRect(10, 10, 300, 15);

            context.fillStyle = "black";
            context.font = "10px Arial";
            context.fillText(msg, 20, 21);
        }
    }

    // ------------------------------------------
    //    functions
    // ------------------------------------------

    function SetDefaultPosition() {
        ExecuteNonQueryCommand(null, "Camera/SetDefaultPosition");
    }

    function ZoomIn() {
        ExecuteNonQueryCommand(null, "Camera/ZoomCameraIn");
    }

    function ZoomOut() {
        ExecuteNonQueryCommand(null, "Camera/ZoomCameraOut");
    }

    // ------------------------------------------
    //    functions (ajax)
    // ------------------------------------------

    function ExecuteNonQueryCommand(data, url) {

        // basic ajax put call
        $.ajax({
            url: url,
            type: "POST",
            async: true,
            contentType: "application/x-www-form-urlencoded; charset=utf-8",
            data: data,
            success: function (result) {
                //console.log(result);
                //toastr["info"](result.statusDescription);
            },
            error: function (result) {
                // return results
                console.log(result);
                toastr["error"](result.statusDescription);
            }
        });
    }

    function ExecuteQueryCommand(url) {

        // basic ajax get call
        $.ajax({
            url: url,
            type: "GET",
            async: true,
            contentType: "application/x-www-form-urlencoded; charset=utf-8",
            success: function (result) {
                //console.log(result);
                //toastr["info"](result.statusDescription);
            },
            error: function (result) {
                // return results
                console.log(result);
                toastr["error"](result.statusDescription);
            }
        });
    }

});