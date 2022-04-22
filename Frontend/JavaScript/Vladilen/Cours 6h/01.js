//1 Переменные
//camelCase

/* var myNameVar = "Maksim"  //устарело
let myNameLet = "Maksim"   //можно менять
const myNameConst = "Maksim"    //нельзя менять
 */

//contcatinate=  + 1

//console.log(contcatinate)
//const inputName =prompt("введите фамилию")  
//alert("Привет,"+ inputName);

//Функции

/* function calculateAge(year){
    return 2020-year
}
const myAge = calculateAge(1998)


function logInfoAbout(name,year) {
    const age = calculateAge(year)
    console.log("Человек по имени "+ name+ " сейчас имеет возраст "+ age)
}

logInfoAbout("Maksim",1998) */

//Массивы

/* const cars = ["Mazda", "BMW", "Mersedes"]
console.log(cars)   
console.log(cars[1])
console.log(cars.length) 

cars[0]="Porshe"
console.log(cars)
cars[3]="Lada"
console.log(cars)
cars[cars.length]="Jeep"
console.log(cars) */

//Циклы

/* const cars = ["Mazda", "BMW", "Mersedes"]
for (let index = 0; index < cars.length; index++) {
    console.log(cars[index])
    
}

for(let car of cars){   //новый цикл for of
    console.log(car)
} */

//Объекты

const person={
    firstName:"Maksim",
    lastName:"Gusev",
    year:1998,
    languages:["Ru","En"],
    hasWife:false,
    greet:function(){
        console.log("greet")
    }
}

console.log(person)
console.log(person.firstName)
person.greet()
console.log(person["lastName"])
console.log(person.languages)
console.log(person.languages[1])
person.isProgrammer = true  //добавляем новую пару
console.log(person)


