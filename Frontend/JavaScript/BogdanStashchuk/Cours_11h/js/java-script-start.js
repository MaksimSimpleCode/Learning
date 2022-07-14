//alert('Hello');



const man = {
    name: 'Maksim',
    age: 23,
    location: {
        city: 'Samara',
        country: 'Russia'
    },
    languages: ['En', 'Ru', 'Fran'],
    getLanguage() {
        for (const key in this.languages) {
            console.log(key);
        }
    },
    convertThisToStr() {
       return JSON.stringify(this)
    },
    convertStrToObj(strJson){
        return  JSON.parse(strJson);
    }
}

//------------------------JSON---------------------------------
//  JSON.parse('Вставляем строку -> конвертируется в объект');

//  JSON.stringify('Вставляем объект -> конвертируется в строку')

//console.log(JSON.stringify(man));


function anotherFunction(){
    console.log('Я просто фнкция')
}

function anotherFunction2(){
    console.log('Я просто фнкция2')
}
function fnWithCallback(callbackFunction){
    callbackFunction();
}

//Тоже пример коллбека:

function printMyName(){
    console.log('Maksim');
}

//Вызываем функцию через определенное время
setTimeout(printMyName,1000);


let myArray=[1,2,3,4,5];