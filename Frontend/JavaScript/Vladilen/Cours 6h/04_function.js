//Функции 

/*let counter = 0
 const interval = setInterval(function(){     //используем анонимную функцию внутри функции setInterval
    if(counter===5){
        clearInterval(interval) 
    }else{
        console.log(++counter)
    }
},1000)
 */

//Стрелочные функции

/* const arrow = (name) =>{
    console.log("Hello! "+ name)
}

const arrow2 = name=>console.log("Hello! "+ name)

arrow("Maksim")
arrow2("Maksim2")

const pow2 = num => num**2      //или в 2 строки с return
console.log(pow2(5))

//Параметры по умолчанию

const sum = (a,b=1)=>a+b
console.log(sum(41))

function sumAll(...all) {   // так можем передавать кучу параметров
    let result = 0
    for (let num of all) {
        result+=num
    }
    return result
}
const res =sumAll(1,3,3,4,5,6,8)
console.log(res) */

//Замыкания

function createMember(name){
    return function(lastName){
        console.log(name + lastName)
    }
}

const logWithLastName=createMember("Maksim")
console.log(logWithLastName(" Gusev"))
console.log(logWithLastName(" Torin"))