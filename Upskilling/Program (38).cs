class Event {
    constructor(name, seats) {
        this.name = name;
        this.seats = seats;
    }
}

Event.prototype.checkAvailability = function () {
    return this.seats > 0
        ? "Seats Available"
        : "Event Full";
};

const event1 = new Event(
    "Music Festival",
    50
);

console.log(event1.checkAvailability());

for (const [key, value] of Object.entries(event1)) {
    console.log(`${key}: ${value}`);
}