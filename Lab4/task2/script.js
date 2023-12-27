document.addEventListener('DOMContentLoaded', function () {
    function drawLines(canvas, x, y) {
        let ctx = canvas.getContext('2d');
        ctx.clearRect(0, 0, canvas.width, canvas.height);
        ctx.beginPath();
        ctx.moveTo(0, 0);
        ctx.lineTo(x, y);
        ctx.moveTo(canvas.width, 0);
        ctx.lineTo(x, y);
        ctx.moveTo(canvas.width, canvas.height);
        ctx.lineTo(x, y);
        ctx.moveTo(0, canvas.height);
        ctx.lineTo(x, y);
        ctx.stroke();
    }

    // Function to clear the canvas
    function clearCanvas(canvas) {
        let ctx = canvas.getContext('2d');
        ctx.clearRect(0, 0, canvas.width, canvas.height);
    }

    // Add event listeners to each canvas with class 'drawingX'
    let canvases = document.querySelectorAll('canvas.drawingX');
    canvases.forEach(function (canvas) {
        canvas.addEventListener('mousemove', function (e) {
            let rect = canvas.getBoundingClientRect();
            let x = e.clientX - rect.left;
            let y = e.clientY - rect.top;
            drawLines(canvas, x, y);
        });

        canvas.addEventListener('mouseleave', function () {
            clearCanvas(canvas);
        });
    });
});
