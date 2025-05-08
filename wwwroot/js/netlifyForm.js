window.submitNetlifyForm = function (formData) {
    const form = document.createElement('form');
    form.method = 'POST';
    form.action = '/';
    form.style.display = 'none';
    form.setAttribute('data-netlify', 'true');
    form.setAttribute('name', 'contact');

    for (const key in formData) {
        if (formData.hasOwnProperty(key)) {
            const input = document.createElement('input');
            input.type = 'hidden';
            input.name = key;
            input.value = formData[key];
            form.appendChild(input);
        }
    }

    document.body.appendChild(form);
    form.submit();
};
