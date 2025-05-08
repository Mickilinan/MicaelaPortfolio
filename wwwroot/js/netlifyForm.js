window.submitNetlifyForm = function (formData) {
    const data = new URLSearchParams(formData).toString();

    fetch("/", {
        method: "POST",
        headers: { "Content-Type": "application/x-www-form-urlencoded" },
        body: data
    })
    .then(() => {
        // Success! Blazor visar tack-meddelandet via isSubmitted
    })
    .catch((error) => {
        alert("Something went wrong. Please try again.");
    });
};
