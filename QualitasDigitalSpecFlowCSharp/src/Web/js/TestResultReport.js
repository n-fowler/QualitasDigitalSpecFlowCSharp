var testStepsDataTest =
[
    {
        "Step Number": "1",
        "Step Description": "Step Description Placeholder",
        "Step Result": "Step Result Placeholder",
        "Step Status": "Pass"
    },
    {
        "Step Number": "2",
        "Step Description": "Step Description Placeholder",
        "Step Result": "Step Result Placeholder",
        "Step Status": "Pass"
    },
    {
        "Step Number": "3",
        "Step Description": "Step Description Placeholder",
        "Step Result": "Step Result Placeholder",
        "Step Status": "Pass"
    },
    {
        "Step Number": "4",
        "Step Description": "Step Description Placeholder",
        "Step Result": "Step Result Placeholder",
        "Step Status": "Pass"
    },
    {
        "Step Number": "5",
        "Step Description": "Step Description Placeholder",
        "Step Result": "Step Result Placeholder",
        "Step Status": "Fail"
    },
    {
        "Step Number": "6",
        "Step Description": "Step Description Placeholder",
        "Step Result": "Step Result Placeholder",
        "Step Status": "Not Executed"
    },
    {
        "Step Number": "7",
        "Step Description": "Step Description Placeholder",
        "Step Result": "Step Result Placeholder",
        "Step Status": "Not Executed"
    }
];

/*DataHere*/

/*HeaderHere*/

function addDataToTbody(nl, data) {
    data.forEach((d, i) => {
        var tr = nl.insertRow(i);
        Object.keys(d).forEach((k, j) => {
            var cell = tr.insertCell(j);
            cell.innerHTML = d[k];
        });
        nl.appendChild(tr);
    });
}

window.addEventListener('load', function () {
    var testStepsTableBody = window.document.querySelector("#TestStepsTable");
    addDataToTbody(testStepsTableBody, testStepsDataTest);
}, false);

// Get the modal
var modal = document.getElementById("myModal");

// Get the image and insert it inside the modal - use its "alt" text as a caption
var img = document.getElementById("TestFailureImage");
var modalImg = document.getElementById("img01");
var captionText = document.getElementById("caption");
img.onclick = function () {
    modal.style.display = "block";
    modalImg.src = this.src;
    captionText.innerHTML = this.alt;
}

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    modal.style.display = "none";
}

function PopupCenter(url, title, w, h) {
    // Fixes dual-screen position                         Most browsers      Firefox
    var dualScreenLeft = window.screenLeft != undefined ? window.screenLeft : window.screenX;
    var dualScreenTop = window.screenTop != undefined ? window.screenTop : window.screenY;

    var width = window.innerWidth ? window.innerWidth : window.document.documentElement.clientWidth ? window.document.documentElement.clientWidth : window.screen.width;
    var height = window.innerHeight ? window.innerHeight : window.document.documentElement.clientHeight ? window.document.documentElement.clientHeight : window.screen.height;

    var systemZoom = width / window.screen.availWidth;
    var left = (width - w) / 2 / systemZoom + dualScreenLeft;
    var top = (height - h) / 2 / systemZoom + dualScreenTop;
    var newWindow = window.open(url, title, 'scrollbars=yes, width=' + w / systemZoom + ', height=' + h / systemZoom + ', top=' + top + ', left=' + left);
    newWindow.onload = function () { newWindow.document.getElementById('EventSource').value = title; }
    // Puts focus on the newWindow
    if (window.focus) newWindow.focus();
}