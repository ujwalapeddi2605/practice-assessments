<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Event Registration Form</title>

    <style>
        body {
            font-family: Arial, sans-serif;
        }

        form {
            width: 400px;
            margin: auto;
            padding: 20px;
            border: 1px solid gray;
            border-radius: 8px;
        }

        input, select, textarea {
            width: 100%;
            padding: 8px;
            margin-top: 5px;
            margin-bottom: 15px;
        }

        button {
            padding: 10px 15px;
            background-color: green;
            color: white;
            border: none;
        }

        output {
            color: green;
            font-weight: bold;
        }
    </style>

    <script>
        function registerEvent(event) {
            event.preventDefault();
            document.getElementById("msg").value =
                "Registration Successful!";
        }
    </script>
</head>
<body>

    <h2 align="center">Event Registration Form</h2>

    <form onsubmit="registerEvent(event)">

        <label>Name</label>
        <input type="text"
               placeholder="Enter your name"
               required
               autofocus>

        <label>Email</label>
        <input type="email"
               placeholder="Enter your email"
               required>

        <label>Date</label>
        <input type="date"
               required>

        <label>Event Type</label>
        <select required>
            <option value="">Select Event</option>
            <option>Music Festival</option>
            <option>Food Festival</option>
            <option>Sports Meet</option>
        </select>

        <label>Message</label>
        <textarea rows="4"
                  placeholder="Enter your message"></textarea>

        <button type="submit">Register</button>
        <br><br>

        <output id="msg"></output>

    </form>

</body>
</html>