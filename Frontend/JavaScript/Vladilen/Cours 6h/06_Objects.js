//Объекты

const person ={
    name:"Maksim",
    age:23,
    isProgrammer:true,
    languages:["ru","en"],
    greet(){
        return "Метод в объекте"
    },
    consoleLog(){
        console.log("Еще метод в объекте")
    },
    "Key":"значение ключа [Key]",
    info(){
        console.info("Инфа о персоне по имени ",this.name)  //this - использует текущий контекст
    }
}

person.consoleLog()
console.log(person["Key"])
console.log(person["isProgrammer"])
console.log(person.isProgrammer)

delete person["Key"]    //удаляем ключ из объекта

console.log(person)

for (key in person){ //перебираем все элементы в объекте
    console.log(key)
   // console.log(person[key])
}

const keys = Object.keys(person)    //более современный способ получить ключи. Не межит по прототипам и не цепляет методы прототипов
console.log(keys)