//DOM

/* if(window.confirm("Как тебя зовут")==true){
    console.log("Ты нажал ОК")
}else{
    console.log("Ты нажал не ОК")
} */

// document -объект представляющий DOM-дерево

//получаем эллемент по id
const heading = document.getElementById("hello")


/* console.dir(heading)    //dir позволяет развернуть получаемый объект в консоли, и понять как с ним взаимодействовать
console.log(heading.textContent)
 */
//программно влияем на элемент Html
/* heading.textContent="Change from JavaScript"
heading.style.color="red"
heading.style.textAlign="center"
heading.style.backgroundColor="black" */

//функция для управления узлом
function addStyleNode(node,text){
    node.textContent=text
    node.style.color="red"
    node.style.textAlign="center"
    node.style.backgroundColor="black"
}

//вызываем через 1,5 секунды
setTimeout(()=>{
    addStyleNode(heading,"javaScript")
},1500)

setTimeout(()=>{
    addStyleNode(heading2,"Is very")
},3000)

setTimeout(()=>{
    addStyleNode(heading3,"HAAAAARD")
},4500)




//получаем коллекцию эллементов, не имея id
//const heading2=document.getElementsByTagName("h2")

//вариант 2
//const heading2=document.getElementsByClassName("h2-class")


//вариант 3 уневирсальный 
//const heading2=document.querySelector("h2") //по тегу
//const heading2=document.querySelector(".h2-class")  //по классу
const heading2=document.querySelector("#sub-hello") //по id

const heading3= document.querySelectorAll("h2")[1]

//* querySelector получает первый попавшийся элемент, другие не выдаст. Нужно использорвать querySelectorAll, если хотим получить все

console.log(heading3)

//События
heading.onclick=()=>{
    if(heading.style.color==="red"){
        heading.style.color="#000"
        heading.style.backgroundColor="#fff"
    }else{
        heading.style.color="red"
        heading.style.backgroundColor="#000"
    }
}

