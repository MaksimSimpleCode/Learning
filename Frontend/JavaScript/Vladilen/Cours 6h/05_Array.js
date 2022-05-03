//Массивы

const cars = ["Mazda", "BMW", "Mersedes","Ford"]



/* cars.push("GAZ")    //Добавить эллемент
cars.pop()          //удаляет последний эллемент
cars.unshift("Lada")    //Добавить в начало
cars.shift()        //Удаляет первый эллемент а так же возвращает его

console.log(cars) */

/* cars.reverse() //перевернуть массив
console.log(cars.indexOf("Mazda"))
 */
/* 
const people = [
    {name:"Maksim", budget:4200},
    {name:"Vika", budget:3200},
    {name:"Jan", budget:400},
]

console.log(people.findIndex(function(people){
    return people.budget===400 
}))

console.log(people.find(function(people){
    return people.budget===400 
}))

console.log(people.find((people)=>people.budget===400)) //Более лаканичный вариант
    
 */
//console.log(cars.includes("Mazda")) //Узнать есть ли значение


//чтобы вернуть новый массив используем map

/* const upperCars = cars.map((car)=>{
    return car.toUpperCase()
})

console.log(upperCars)  //все заглавные
console.log(cars)       //без изменений */

/* const pow2 = num=>num**2
const fib = [1,1,2,3,5,8,13]
const pow2Fib = fib.map(pow2)


const filetersArray = pow2Fib.filter(num=>num>20)

console.log(pow2Fib)
console.log(filetersArray) */

const people = [
    {name:"Maksim", budget:4200},
    {name:"Vika", budget:3200},
    {name:"Jan", budget:400},
]

const allBudget =people.filter(person=>person.budget>500).reduce((acc,person)=>{    //Складываем бюджет всех персон у которых б>500
    acc+=person.budget
    return acc
}, 0)


console.log(allBudget)