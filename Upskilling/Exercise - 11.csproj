let events = [];

function addEvent(name, category) {
    events.push({ name, category });
}

function registerUser(user, event) {
    console.log(`${user} registered for ${event}`);
}

function filterEventsByCategory(category, callback) {
    const filtered = events.filter(
        event => event.category === category
    );

    callback(filtered);
}

function registrationTracker() {
    let count = 0;

    return function () {
        count++;
        return count;
    };
}

const trackMusic = registrationTracker();

addEvent("Music Festival", "Music");
addEvent("Food Fair", "Food");

registerUser("John", "Music Festival");

console.log(trackMusic());
console.log(trackMusic());

filterEventsByCategory("Music", function(result) {
    console.log(result);
});