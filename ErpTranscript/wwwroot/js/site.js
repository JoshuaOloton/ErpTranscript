// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(() => {
    $('#example').DataTable({
        //'info': false,
        'paging': false,
        //'searching': false
    });
    $('#example1').DataTable({
        //'info': false,
        'paging': false,
        //'searching': false
    });
    $('#example2').DataTable({
        'info': false,
        'paging': false,
        //'searching': false
    });

    document.querySelectorAll('input[type=file]').forEach(input => {
        input.addEventListener('change', event => {
            console.log(event.target.value);
            console.log(document.querySelector('#student-stuff'));
            document.querySelector('#student-stuff').value = event.target.value;
        })
    });

    document.getElementById('preview-ok').addEventListener('click', (e) => {
        console.log('Button clicked!');
        const transcriptID = e.target.dataset.transcriptid;
        console.log(transcriptID);

        fetch(`/Pending/?transcriptID=${transcriptID}&handler=Confirm`, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        console.log('Response complete!');
        //console.log(response);
        e.target.style.display = "none";
        e.target.nextElementSibling.style.display = "block";
        // Delay for 1.5sec then reload the page
        setTimeout(() => {
            location.reload();
            console.log('Reload complete!');
        }, 1500);
    });
});

function LoginSubmit(event) {   // THIS FUNCTION UPDATES A BUTTON'S TEXT AND STATE TO INDICATE LOADING, AND THEN SUBMITS THE FORM.
    //event.preventDefault();
    const button = event.target.querySelector("button");
    button.innerHTML = "LOADING..."
    button.disabled = true;
    button.style.backgroundColor = "#225325";
    //event.target.submit();
}

function transUpload() {
    let remita;
    if (event.target.tagName === "BUTTON") {
        remita = event.target.dataset.remita;
    }
    else {
        const button = event.target.parentElement;
        remita = button.dataset.remita;
    }
    const hiddenRemitaField = document.querySelector(".hidden-remita");
    hiddenRemitaField.value = remita;
}

var TransSubmit = () => {
    console.log("Start");
    const confirmApprove = confirm("Are you sure you want to proceed with transcript approval?");
    if (confirmApprove) {
        const button = event.target;
        const remita = button.dataset.remita;
        //const remitaVal = event.target.dataset.remita;
        const hiddenRemitaField = document.querySelector(".hidden-remita");
        hiddenRemitaField.value = remita;

        //console.log(remitaVal);

        //event.preventDefault();
        //const returnPage = button.dataset.returnpage;
        console.log(remita);

        const formSubmit = document.getElementById("approve-form");
        console.log(formSubmit);
        formSubmit.submit();
        console.log("Form submitted");
    }

    //const confirmDelete = confirm('Are you sure you want to approve?');
    //console.log(confirmDelete);
    //if (confirmDelete) {
    //    window.location.href = `/Uploaded?remita=${remita}&returnPage=${returnPage}&handler=Delete`;
    //}
};

function submitFeedback() {
    console.log("Submit clicked");
    const remitaNo = event.target.dataset.remita;
    //const hiddenRemitaField = document.querySelector(".hidden-remita");
    const hiddenRemitaField = document.querySelector(".hidden-rrr");
    hiddenRemitaField.value = remitaNo;

    console.log(remitaNo);
    console.log(hiddenRemitaField.value);
}

function toggleFeedbackForm() {
    //console.log("Toggle clicked");
    const modal = document.querySelector(".feedback-modal-wrapper");
    if (modal.dataset.show === "false") { // show modal

        if (event.target.tagName === "P") {
            modal.querySelector(".submit-feedback").dataset.remita = event.target.dataset.remita;
            modal.querySelector(".submit-feedback").value = event.target.dataset.remita;
            modal.dataset.show = "true";
        }
    }
    else {  // hide modal
        modal.dataset.show = "false";
        modal.querySelector(".submit-feedback").removeAttribute("data-remita");
    }
}

async function toggleFeedbackMessage(event) {
    console.log("Feedback click");
    console.log(event.target);
    const modal = document.querySelector(".feedback-message-wrapper");
    const feedbackBy = document.querySelector(".feedback-message-wrapper .feedback-by");
    const feedbackP = document.querySelector(".feedback-message-wrapper .feedback-message");

    if (modal.dataset.show === "false") {
        modal.dataset.show = "true";
        // Since the child icon also trigers the event,...
        // if it is clicked, fetch the remita dataset attribute of the parent div element
        let rrr;
        if (event.target.tagName === "DIV") {
            rrr = event.target.dataset.remita;
        }
        else {
            rrr = event.target.parentElement.dataset.remita;
        }
        console.log(`RRR: ${rrr}`);
        const response = await fetch(`/GetMessage?rrr=${rrr}`);
        if (response.ok) {
            console.log("OK");
            const feedbackMsg = await response.json();
            // Use the feedbackMsg here as needed.
            feedbackBy.innerHTML = `Flagged by ${feedbackMsg["flagBy"]}`;
            feedbackP.innerHTML = feedbackMsg["flagMsg"];
            console.log(feedbackMsg);
        } else {
            console.log("FAIL");
            console.error("Error fetching feedback message:", response.status);
        }
    } else {
        modal.dataset.show = "false";
    }
}

function toggleConfirmDialog() {
    let modal;
    if (event.target.classList.contains("del")) {
        modal = document.querySelector(".confirm-delete-modal");
        console.log(1);
    }
    else if (event.target.classList.contains("close")) {
        modal = document.querySelector(".confirm-close-modal");
        console.log(2);
    }
    else {
        modal = document.querySelector(".confirm-approve-modal");
        console.log(3);
    }

    if (modal.dataset.show === "false") {        

        modal.dataset.show = "true";
        //const button = event.querySelector(".modal-content .btn-wrapper button");
        if (event.target.classList.contains("close")) {
            console.log("CLOSSEEEE");
            const link = document.querySelector(".confirm-close-modal .btn-wrapper a");
            link.setAttribute("href", `Approved?remita=${event.target.dataset.remita}&handler=CloseRequest`);
        }
        else {
            const hiddenField = modal.querySelector(".process-remita");
            //button.dataset.remita = event.target.dataset.remita;
            hiddenField.value = event.target.dataset.remita;
            console.log("MMMM");
            console.log(hiddenField.value);
        }
    } else {
        modal.dataset.show = "false";
    }
}

function showDropdown() {
    const allDropdowns = document.getElementsByClassName("dropdown-content");
    console.log(allDropdowns);
    let i;
    for (i = 0; i < allDropdowns.length; i++) {
        var openDropdown = allDropdowns[i];
        if (openDropdown.classList.contains('show')) {
            console.log("Removed");
            openDropdown.classList.remove('show');
        }
    }
    const dropdown = event.target.nextElementSibling;
    dropdown.classList.add("show");
}

function showModal() {
    console.log(event.target.dataset.remita);
    const iframe = document.querySelector("iframe");
    document.querySelector('.document-modal').style.display = 'block';

    const remitaNo = event.target.dataset.remita;

    const filePath = `../uploads/${remitaNo}-OFFICIAL_COPY.pdf`;
    console.log(filePath);

    iframe.setAttribute("src", filePath);
}

function deleteTranscript() {
    event.preventDefault();
    const button = event.target;
    const remita = button.dataset.remita;
    const returnPage = button.dataset.returnpage;
    console.log(remita);
    const confirmDelete = confirm('Are you sure you want to delete?');
    console.log(confirmDelete);
    if (confirmDelete) {
        window.location.href = `/Uploaded?remita=${remita}&returnPage=${returnPage}&handler=Delete`;
    }
}

const documentModal = document.querySelector('.document-modal');
window.onclick = function (event) {
    // when the user clicks anywhere outside the document-modal, close the document-modal
    if (event.target == documentModal) {
        console.log('click2');
        documentModal.style.display = 'none';
    }

    if (!event.target.matches('.dropBtn')) {
        var dropdowns = document.getElementsByClassName("dropdown-content");
        var i;
        for (i = 0; i < dropdowns.length; i++) {
            var openDropdown = dropdowns[i];
            if (openDropdown.classList.contains('show')) {
                openDropdown.classList.remove('show');
            }
        }
    }
}

