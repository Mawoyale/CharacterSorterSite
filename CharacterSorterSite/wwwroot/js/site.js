const selectAllButton = document.querySelector("#SelectAllButton");
const deselectAllButton = document.querySelector("#DeselectAllButton");

selectAllButton.addEventListener("click", function () {
    const franchiseIds = document.querySelectorAll(".franchise-checkbox");
    for (const franchiseId of franchiseIds) {
        franchiseId.checked = true;
    }
});

deselectAllButton.addEventListener("click", function () {
    const franchiseIds = document.querySelectorAll(".franchise-checkbox");
    for (const franchiseId of franchiseIds) {
        franchiseId.checked = false;
    }
})