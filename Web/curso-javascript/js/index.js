//console.log('arquivo carregado') //commited

/*/
var nome = 'Thiago'
//Create variable
var idade = 25
var peso = 85.5
var maiorDeIdade = true
maiorDeIdade = 'false'
//see value of variable with the type
console.log(nome,typeof nome)
console.log(idade,typeof idade)
console.log(peso,typeof peso)
console.log(maiorDeIdade,typeof maiorDeIdade)
/*/

/*/
//create array
var nomes = [
    'joão',
    'maria',
    'pedro',
    //true // is validad
]
console.log(nomes[1])

//create object
var pessoa = {
    nome: 'bruno',
    amigos: [
        'joão',
        'maria',
        'pedro'
    ]
}

console.log(pessoa.amigos[2])
/*/

/*/
var peso = 80
var altura = 1.83
var imc = peso / (altura*altura)

imc += 10
imc -= 10
imc ++
//imc --

console.log(imc)
/*/

/*/
var comprarRefrigerante = false
var comprarCerveja = false
var comprarSucoNatural = false

var convidado = {
    nome: 'pedro',
    idade: 17,
    bebeCerveja:true,
    bebeRefrigerante:false,
}

if(convidado.bebeRefrigerante){
    comprarRefrigerante=true
}else if(convidado.bebeCerveja && convidado.idade >= 18){
    comprarCerveja=true
}else{
    comprarSucoNatural = true
}


console.log(comprarRefrigerante)
console.log(comprarCerveja)
console.log(comprarSucoNatural)
/*/

/*/

var comprarRefrigerante = false
var comprarCerveja = false
var comprarSucoNatural = false

var convidados = [
    {
        nome: 'pedro',
        idade: 17,
        bebeCerveja:true,
        bebeRefrigerante:true,
    },
    {
        nome: 'Joao',
        idade: 23,
        bebeCerveja:false,
        bebeRefrigerante:true,
    },
    {
        nome: 'Kilson',
        idade: 34,
        bebeCerveja:true,
        bebeRefrigerante:true,
    },
    {
        nome: 'Felipe',
        idade: 20,
        bebeCerveja:true,
        bebeRefrigerante:false,
    },
]

var count = 0
console.log(convidados.count)
for(var i= 0; i< convidados.length; i++){

       
    if(convidados[i].bebeRefrigerante){
        comprarRefrigerante=true
    }else if(convidados[i].bebeCerveja && convidados[i].idade >= 18){
        comprarCerveja=true
    }else{
        comprarSucoNatural = true
    }
    console.log(convidados[i].nome, comprarRefrigerante, comprarCerveja , comprarSucoNatural)
  
}
/*/


/*/
IMC(80.70,1.75)
IMC(90.70,1.75)

function IMC(peso,altura){
    var imc = peso / (altura*altura)

    imc += 10
    imc -= 10
    imc ++
    //imc --

    console.log(imc)
    return imc
}
/*/

var pessoas = [
    {
        nome:'Thiago',
        altura: 1.70,
        peso:80
    },
    {
        nome:'Luiz',
        altura: 1.90,
        peso:20
    },
    {
        nome:'Rodrigo',
        altura: 2,
        peso:90
    },
    {
        nome:'Jose',
        altura: 1.40,
        peso:65
    }
]

function IMC(peso,altura){
    var imc = peso / (altura*altura)

    imc += 10
    imc -= 10
    imc ++
    //imc --

    return imc
}


for(var pessoa of pessoas){
  var resultado =IMC(pessoa.peso,pessoa.altura)

  console.log(pessoa.nome , resultado)

}