// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


if (document.querySelector("#updateChecklistButton")) {
    let updateChecklistButton = document.querySelector("#updateChecklistButton");

    updateChecklistButton.addEventListener("click", (event) => {
        let franchiseCheckboxes = document.querySelectorAll(".franchise-checkbox");
        console.log(franchiseCheckboxes);

        for (const franchiseCheckbox of franchiseCheckboxes) {
            console.log(franchiseCheckbox.nextElementSibling.textContent, franchiseCheckbox.checked, franchiseCheckbox.value);
            //console.log(franchiseCheckbox.checked);
            //console.log(franchiseCheckbox.value);
        }
    });
}

if (document.querySelector("#proceedButton")) {
    let proceedButton = document.querySelector("#proceedButton");

    proceedButton.addEventListener("click", (event) => {
        //https://localhost:7244/voting/index/{franchiseID}
        let boxesChecked = document.querySelectorAll('input[type="checkbox"]:checked')
        //console.log(boxChecked);
        //console.log(boxChecked.value);

        let franchiseIds = [];

        for (const boxChecked of boxesChecked) {
            franchiseIds.push(boxChecked.value);
        }

        let franchiseIdsString = franchiseIds.join(", ");
        console.log(franchiseIdsString);


        let franchiseForm = document.querySelector("#franchiseForm");
        console.log(franchiseForm);
        franchiseForm.innerHTML = `<input type='text' name='ids' value='${franchiseIdsString}'>`;
        franchiseForm.submit();
    });
}



 