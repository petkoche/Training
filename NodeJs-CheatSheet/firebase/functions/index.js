const functions = require('firebase-functions');
const firebase = require('firebase-admin');
const express = require('express');
const engines = require('consolidate');

const firebaseApp = firebase.initializeApp(
    functions.config().firebase
);

function getFacts(){
    const ref = firebaseApp.database().ref('facts');
    
    let res = ref.once('value').then(snap => snap.val());
    return res;
}

const app = express();
app.engine('hbs', engines.handlebars);
app.set('views,', '/views');
app.set('view engine', 'hbs');

app.get('/', (req, res) => {
    res.set('Cache-Control', 'public, max-age=300, s-maxage=600');
    getFacts().then(facts => {
        console.log(facts);
        res.render('index', { facts });
    });    
});

exports.app = functions.https.onRequest(app);
