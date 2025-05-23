/* Reset some default styles */
body, h1, p {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

/* Body styles */
body {
    font-family: 'Arial', sans-serif;
    line-height: 1.6;
    color: #444;
    background: linear-gradient(to right, #f0f0f0, #ffffff);
    padding: 20px;
}

/* Heading styles */
h1 {
    text-align: center;
    color: #2c3e50;
    font-size: 2.5rem;
    text-transform: uppercase;
    margin-bottom: 20px;
}

/* Image gallery container */
img {
    border-radius: 10px;
    box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
    transition: transform 0.3s ease, box-shadow 0.3s ease;
    display: block;
    margin: 0 auto 20px auto;
}

img:hover {
    transform: scale(1.05);
    box-shadow: 0 6px 8px rgba(0, 0, 0, 0.15);
}

/* Paragraph styles */
p {
    background: #ffffff;
    border: 1px solid #ddd;
    border-radius: 10px;
    padding: 20px;
    box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
    max-width: 600px;
    margin: 20px auto;
    text-align: left;
}

/* Responsive grid for images */
.image-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    gap: 20px;
    max-width: 1200px;
    margin: 0 auto;
    padding: 10px;
}

/* Responsive styles */
@media (max-width: 768px) {
    h1 {
        font-size: 2rem;
    }
    p {
        font-size: 1rem;
    }
    img {
        width: 90%;
        height: auto;
    }
}
