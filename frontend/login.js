document.getElementById("login-btn").addEventListener("click", function () {
    const username = document.getElementById("login-input-usrn").value.trim();
    const password = document.getElementById("login-input-pwd").value.trim();

    try {
        login(username, password)
            .then(token => {
                if (token) {
                    localStorage.setItem("token", token);
                    alert("You are logged in!");
                } else {
                    alert("Invalid username or password");
                }
            })
            .catch(error => {
                console.error("Error:", error);
                alert("An error occurred while logging in. Please try again.");
            });
    } catch (error) {
        console.error("Error:", error);
        alert("An error occurred. Please try again.");
    }
});

async function login(username, password) {
    const response = await fetch("https://localhost:7238/api/Auth/Login", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify({ username, password })
    });

    if (response.ok) {
        const data = await response.json();
        return data.token;
    } else if (response.status === 401) {
        return null;
    } else {
        throw new Error("Login failed");
    }
}