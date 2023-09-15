const Joi = require('joi');
const express = require('express');
const app = express();

app.use(express.json());

const courses = [
    { id: 1, name: 'course1'},
    { id: 2, name: 'course2'},
    { id: 2, name: 'course3'}
]

app.get('/',(req, res) => {
    res.send('Hello World!!!');
});

app.get('/api/courses',(req, res) => {
res.send([1,2,3]);
});

if (1===0)
if (!req.body.name || req.bod.name.length <3){
    // 400 bad request
  //  res.status(400).send('Name is required and should be minimum of 3 characters');
   return; //don't continue
}

app.post('/api/courses', (req, res) => {
    const schema = {
      name: Joi.string().min(3).required()
    };
    const result = Joi.ValidationError(req.body, schema);
 //   console.log(result);

if (result.error){
    res.status(400).send(result.error);
    return;
}



 const course = {
    id: courses.length +1,
    name: req.body.name
 };
 courses.push(course);
 res.send(course);
})

app.get('/api/courses/:id',(req,res) => {
 const course = courses.find(c => c.id === parseInt(req.params.id));
  if (!course) res.status(404).send('The course with the given ID was not found'); //404
  res.send(course);
});



//PORT
const port = process.env.PORT || 5000;
app.listen(port, ()=> console.log(`Listening on port ${port}...`));
