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

// Close mobile menu when clicking outside
function setupMobileMenu() {
    const mobileMenu = document.querySelector('.nav-links');
    const menuToggle = document.querySelector('.menu-toggle');
    
    if (mobileMenu && menuToggle) {
        // Close menu when clicking outside
        document.addEventListener('click', (event) => {
            const isClickInsideMenu = mobileMenu.contains(event.target);
            const isClickOnToggle = menuToggle.contains(event.target);
            
            if (!isClickInsideMenu && !isClickOnToggle && mobileMenu.classList.contains('open')) {
                mobileMenu.classList.remove('open');
            }
        });
        
        // Close menu when clicking on a link
        const menuLinks = mobileMenu.querySelectorAll('a');
        menuLinks.forEach(link => {
            link.addEventListener('click', () => {
                mobileMenu.classList.remove('open');
            });
        });
    }
}

// Initialize when DOM is ready
document.addEventListener('DOMContentLoaded', setupMobileMenu);

// Also initialize after Blazor loads
window.addEventListener('load', setupMobileMenu);

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