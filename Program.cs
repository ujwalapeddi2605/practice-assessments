const events = [
    { name: "Music Festival", seats: 20, upcoming: true },
    { name: "Food Fair", seats: 0, upcoming: true },
    { name: "Old Event", seats: 10, upcoming: false }
];

const output = document.getElementById("events");

events.forEach(event => {
    if (event.upcoming && event.seats > 0) {
        output.innerHTML += `<p>${event.name}</p>`;
    }
});

function register(event) {
    try {
        if (event.seats <= 0) {
            throw new Error("No seats available");
        }

        event.seats--;
        console.log("Registration Successful");
    }
    catch (error) {
        console.log(error.message);
    }
}

register(events[0]);
register(events[1]);