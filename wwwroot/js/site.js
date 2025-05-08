// Initialize AOS (Animate on Scroll)
function initAOS() {
    const elements = document.querySelectorAll('[data-aos]');

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('aos-animate');
            } else {
                entry.target.classList.remove('aos-animate');
            }
        });
    }, {
        threshold: 0.1
    });

    elements.forEach(element => {
        observer.observe(element);

        // Add delay if specified
        const delay = element.getAttribute('data-aos-delay');
        if (delay) {
            element.style.transitionDelay = `${delay}ms`;
        }
    });
}

// Theme toggle functionality
//document.addEventListener('DOMContentLoaded', () => {
//    // Check for saved theme preference
//    const savedTheme = localStorage.getItem('theme');
//    if (savedTheme === 'dark') {
//        document.body.classList.add('dark-theme');
//    } else {
//        document.body.classList.remove('dark-theme');
//    }
//});