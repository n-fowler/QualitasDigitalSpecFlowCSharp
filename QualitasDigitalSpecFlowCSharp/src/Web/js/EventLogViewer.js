var eventDataTest =
[
    {
        "Level": "Level Placeholder",
        "DateAndTime": "Date and Time Placeholder",
        "Source": "Source Placeholder",
        "Task Category": "Task Category Placeholder"
    },
    {
        "Level": "Level Placeholder",
        "DateAndTime": "Date and Time Placeholder",
        "Source": "Source Placeholder",
        "Task Category": "Task Category Placeholder"
    },
    {
        "Level": "Level Placeholder",
        "DateAndTime": "Date and Time Placeholder",
        "Source": "Source Placeholder",
        "Task Category": "Task Category Placeholder"
    },
    {
        "Level": "Level Placeholder",
        "DateAndTime": "Date and Time Placeholder",
        "Source": "Source Placeholder",
        "Task Category": "Task Category Placeholder"
    },
    {
        "Level": "Level Placeholder",
        "DateAndTime": "Date and Time Placeholder",
        "Source": "Source Placeholder",
        "Task Category": "Task Category Placeholder"
    },
    {
        "Level": "Level Placeholder",
        "DateAndTime": "Date and Time Placeholder",
        "Source": "Source Placeholder",
        "Task Category": "Task Category Placeholder"
    }
];

var detailDataTest =
[
    {
        "Details": "Event Details Placeholder One"
    },
    {
        "Details": "Event Details Placeholder Two"
    },
    {
        "Details": "Event Details Placeholder Three"
    },
    {
        "Details": "Event Details Placeholder Four"
    },
    {
        "Details": "Event Details Placeholder Five"
    },
    {
        "Details": "Event Details Placeholder Six"
    }
];

/*DataHere*/

function addDataToTbody(nl, data) { 
    data.forEach((d, i) => {
        var tr = nl.insertRow(i);
        Object.keys(d).forEach((k, j) => { 
            tr.setAttribute("onclick", "FillDetails(this.rowIndex-1);");
            var cell = tr.insertCell(j);
            cell.innerHTML = d[k];  
        });
        nl.appendChild(tr);
    });
}

window.addEventListener('load', function () {
    var eventTableBody = window.document.querySelector("#EventLogTable");

    if (window.document.getElementById('EventSource').value === "Critical") {
        addDataToTbody(eventTableBody, eventDataCritical);
    } else if (window.document.getElementById('EventSource').value === "Error") {
        addDataToTbody(eventTableBody, eventDataError);
    } else if (window.document.getElementById('EventSource').value === "Warning") {
        addDataToTbody(eventTableBody, eventDataWarning);
    } else if (window.document.getElementById('EventSource').value === "Information") {
        addDataToTbody(eventTableBody, eventDataInformation);
    } else {
        addDataToTbody(eventTableBody, eventDataTest);
    }
}, false);

function FillDetails(index) {
    if (window.document.getElementById('EventSource').value === "Critical") {
        window.document.querySelector("#EventLogDetails").value = detailDataCritical[index].Details;
    } else if (window.document.getElementById('EventSource').value === "Error") {
        window.document.querySelector("#EventLogDetails").value = detailDataError[index].Details;
    } else if (window.document.getElementById('EventSource').value === "Warning") {
        window.document.querySelector("#EventLogDetails").value = detailDataWarning[index].Details;
    } else if (window.document.getElementById('EventSource').value === "Information") {
        window.document.querySelector("#EventLogDetails").value = detailDataInformation[index].Details;
    } else {
        window.document.querySelector("#EventLogDetails").value = detailDataTest[index].Details;
    }
}