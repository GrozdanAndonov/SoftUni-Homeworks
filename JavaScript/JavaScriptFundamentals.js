 function sum3Nums(numbers){

     let num1=Number(numbers[0]);
     let num2=Number(numbers[1]);
    let num3=Number(numbers[2]);
     let sum=Number(num1+num2+num3);
     console.log(sum);
 }
function sumAndVat(values){
    let sum=0;
     for(let n of values){
         sum+=Number(n);
    }
     console.log("sum="+sum);
     console.log("VAT="+sum*0.2);
    console.log("total="+sum*1.2);

}

function letterCounter(word,letter){
    let counter=0;
    let n=letter.toLowerCase();
   let m=word.toLowerCase();
    for(let l of m){
        if(l==n) Number(counter++);
    }
    console.log(counter);
}

function nameAndAge(minAge,nameA,ageA,nameB,ageB){

    let personA={name:nameA,age:Number(ageA)};
    let personB={name:nameB,age:Number(ageB)};
    if(personA.age>=minAge) console.log(personA);
    if(personB.age>=minAge) console.log(personB);
}

function concatNum(num){
    let n=Number(num);
    let str='';
    for(let a=1;a<=n;a++) {
        str+=a;
    }
    console.log(str);
}

function areaValue(values){

    let area=0;
    let figure1=0;
    let figure2=0;
    let figure3=0;
        figure1=Number(values[2]*values[3]);
        figure2=Number(values[0]*values[1]);
        figure3=Number(Math.min(values[0],values[2])*Math.min(values[1],values[3]));

    area=figure1+figure2-figure3;

console.log(area);
}

function nextDay(day){
    let dayNow=new Date(day[0],day[1]-1,day[2]);
    let oneDay=24*60*60*1000;
    let nextDate=new Date(dayNow.getTime()+oneDay);
    console.log(nextDate.getFullYear()+"-"+(nextDate.getMonth()+1)+'-'+nextDate.getDate());
}

function distanceBetween2points(coordinates){
        let pointA={x:coordinates[0],y:coordinates[1]};
        let pointB={x:coordinates[2],y:coordinates[3]};

        let distanceX=Math.pow(pointA.x-pointB.x,2);
        let distanceY=Math.pow(pointA.y-pointB.y,2);
        let result=Math.sqrt(distanceX+distanceY);
    console.log(result);
   
}

function multiply(nums){
    let result=nums[0]*nums[1];
    console.log(result);
}

function bottles(info) {
console.log(Math.ceil(info[0]/info[1]));
}

function leapYear(year){
    if(((year%4==0)&&(year%100!=0)||year%400==0)){
        console.log("leap year")
    }else
    {
        console.log("not a leap year");
    }

}
function circleArea(radius){
    "use strict";
    let area= Math.PI*radius*radius;
    console.log(area);
    console.log(Math.round(area*100)/100);

}

function triangleArea(side){
    "use strict";
    side=side.map(Number);
    let s=(side[0]+side[1]+side[2])/2;
    console.log(s);
    let area=Math.sqrt(s*(s-side[0])*(s-side[1])*(s-side[2]));
    console.log(area);

}
function copeAreaVolume(parameters){
    "use strict";
    parameters=parameters.map(Number);
    let V=Math.PI*parameters[0]*parameters[0]*parameters[1]/3;
    V=Math.round(V*10000)/10000;
    let S=Math.sqrt(parameters[0]*parameters[0]+parameters[1]*[parameters[1]]);
    let totalArea=Math.PI*parameters[0]*parameters[0]+Math.PI*parameters[0]*S;
    totalArea=Math.round(totalArea*1000)/1000;
    console.log(V);
    console.log(totalArea);
}

function OddOrEven(num) {
    "use strict";
    let rem=num%2;
    if(rem==0){
        console.log("even");
    }else if(rem==Math.round(rem)){
        console.log("odd");
    } else console.log("invalid");

}
function fruitOrVegetable(sth) {
    switch (sth){
        case 'banana':
        case "apple":
        case "kiwi":
        case "cherry":
        case "lemon":
        case "grapes":
        case "peach":
            console.log("fruit");
            break;
        case "tomato":
        case "cucumber":
        case "pepper":
        case "onion":
        case "parsley":
        case "garlic":
            console.log("vegetable");
            break;
        default:
            console.log("unknown");
    }
}

function evenOrOdd(n){
    "use strict";
    let html="<ul>\n";
    for(let a=1;a<=n;a++){
        let color = "blue";
        if(a%2!=0)color="green";
        html+="<li><span style='color=${color}'>${a}</span></li>\n";
    }
    html+='</ul>';
return html;
}


function logarithum(nums){
    "use strict";
    for(let n of nums){
        console.log(Math.log2(n));
    }
}

function primeChecher(num){
    "use strict";
    let p=0;
    let nP=0;
    for(let n=2;n<num;n++){
        if(num%n!=0){
            p++;
        }else nP++;
    }
    if(nP==0){
        console.log("true");
    }else console.log("false");
}
//////////////////////////////////////////////////////////////////////////
function greetings(name){
    "use strict";
    console.log("Hello,"+name+" I am JavaScript!");
}
function areaAndPerimetter(side){
    "use strict";
    let a =Number(side[0]);
    let b=Number(side[1]);
    console.log("Area="+Math.round(a*b*100)/100);
    console.log("Perimeter="+Math.round(((a*2)+(b*2))*100)/100);
}

function  distanceTime(parameters){


    let V1=Number(parameters[0]);
    let V2=Number(parameters[1]);
    let  t=Number(parameters[2]);
      t=t/(60*60);
    let A = V1*t;

    let B=V2*t;

    let result=Math.abs(A-B)*1000;
    console.log(result);
}
function distance3D(points){
    let x1=Number(points[0]);
    let y1=Number(points[1]);
    let z1=Number(points[2]);
    let x2=Number(points[3]);
    let y2=Number(points[4]);
    let z2=Number(points[5]);
if(z1==0 && z2==0) {
    let a = Math.abs(x1 - x2);
    let b = Math.abs(y1 - y2);
    let result = (a * a) + (b * b);
    result = Math.sqrt(result);
    console.log(result);
}else{
    let a = Math.abs(x1 - x2);
    let b = Math.abs(y1 - y2);
    let c=Math.abs(z1-z2);

    let result = (a * a) + (b * b)+(c*c);
    result = Math.sqrt(result);
    console.log(result);
}
}
function gradsToDegrees(grads) {
    let gradi=Number(grads);
    if(gradi<=0) gradi=360-gradi;
    if(gradi>360) gradi=gradi
}

function triangleOfStars(num) {
    let n = Number(num);
    if (n == 1) {
        console.log("*");
    } else {
        for (let row = 1; row <= n; row++) {
            console.log("*".repeat(row));
        }
        for (let row = num - 1; row >= 1; row--) {
            console.log("*".repeat(row));
        }

    }
}

function squareOfStars(num){
    "use strict";

    for(let n=0;n<num;n++){
        console.log("* ".repeat(num));
    }

}
function isPalindrom([string]){

    for(let i=0;i<string.length/2;i++)
        if (string[i] != string[string.length - i-1]){
            //console.log("false");
            return false;}

     return true;
}

function dayOfWeek(day){

    //day.toLowerCase();
    switch (day) {
        case "Monday":return 1;
            break;
        case "Tuesday":return 2;
            break;
        case "Wednesday": return 3;
            break;
        case "Thursday":return 4;
            break;
        case "Friday":return 5;
            break;
        case "Saturday":return 6;
            break;
        case "Sunday":return 7;
            break;
        default:return "error";
            break;
    }
}

function calcNums([a,b,op]) {
    // let n1=Number(nums[0]);
    // let n2=Number(nums[1]);
    //
    // if(nums[2]=="+"){
    //     console.log(n1+n2);
    //     return n1+n2;
    // }else{
    //     if(nums[2]=="-"){
    //         console.log(Math.abs(n1-n2));
    //         return Math.abs(n1-n2);
    //     }else{
    //         if(nums[2]=="*"){
    //             console.log(n1*n2);
    //             return n1*n2;
    //     }else{
    //             if(nums[2]=="/"){
    //                 console.log(n1/n2);
    //                 return n1/n2;
    //             }
    // }

//}}
    [a,b]=[a,b].map(Number);
    let add=function(a,b){console.log(a+b); return a+b;};
    let subtract=function (a,b) {console.log(Math.abs(a-b));return Math.abs(a-b);};
    let multiply=function (a,b) {console.log(a*b);return a*b;};
    let divide =function (a,b) {console.log(a/b);return a/b;};

    if(op=="+") add(a,b);
    if(op=="-") subtract(a,b);
    if(op=="*") multiply(a,b);
    if (op=="/") divide(a,b);
}

function agregateElements(elements){
    "use strict";

    let Sum=function (elements) {
       let nums= elements.map(Number);
        let result=0;
        for(let n of nums){
            result=result+n;
        }
        console.log(result);
        return result;
    }
    let Sum2=function (elements) {
        elements.map(Number);

        let result=0;
        for(let n of elements){
            result=result+1/n;
        }
        console.log(result);
        return result;
    }
    let concat=function (elements){
        let result="";
        for(let n of elements){
            result=result+n;
        }
        console.log(result);
        return result;
    }
  Sum(elements);
    Sum2(elements);
    concat(elements);
}

function sumFurtLast(arr) {
    //console.log(Number(arr[0])+Number(arr[arr.length-1]));
    return Number(arr[0])+Number(arr[arr.length-1]);
}

function evenShow(arr) {
    let narr="";
    for(let n=0;n<arr.length;n++){
        if(n%2==0){
           narr=narr+" "+ arr[n];
        }
    }
    return narr;
}

function NandPnums(arr){
    arr.map(Number);
    let arr1=[];
    let arr2=[];
    let count=0;
    let count2=0;
    for(let n=0;n<arr.length;n++){
        if(arr[n]>=0){
            arr1[count]=arr[n];
            count++;
        }else
        {
            arr2[count2]=arr[n];
            count2++;
        }
    }
    for(let n of arr2){
        console.log(n+"\n");
    }
    for (let n of arr1){
        console.log(n+ "\n");
    }
}


function lastKsequence(arr){
    "use strict";
    arr.map(Number);
    let k =arr[0];
    let arr1=[];
    let arr2=[];
    let count=0;
    arr.shift();
for(let r=0;r<k;r++){
    arr1[r]=arr[r];
}
for(let r=arr.length-k;r<arr.length;r++){
    arr2[count]=arr[r];
    count++;
}
console.log(arr1.join(' '));
    console.log(arr2.join(' '));

}

function stringCount(string){
    "use strict";
    if(Array.isArray(string)){
        string=string[0];
    }
    for(let l in string){
        console.log(`str[${l}] -> ${string[l]}`);
    }
}

function concatReverse(input){
    "use strict";
let allStrings=input.join("");
    let chars=Array.from(allStrings);
    let revChars=chars.reverse();
    let revStr=revChars.join("");
    console.log(revStr);
}

function excersise(array){
    "use strict";

    array.push(200);
console.log(array);
    array.pop();
    console.log(array);
    array.shift();
    console.log(array);
    array.unshift(300);
    console.log(array);
    array.push(400);
    array.push(500);
    console.log(array);
    //let arr=array.splice(2,4);
    //console.log(arr);
    //console.log(array);
    array.sort((a,b)=>a-b);
    console.log(array);
}

function countOccurrences([str,text]) {
    let count=0;
    let index=text.indexOf(str);
    while(index>0){
        count++;
        index=text.indexOf(str,index+1);
    }
    console.log(count);
    return count;
}

function oc([str,text]){

    let count=0;
    let index=text.indexOf(str);
    while(index!=-1){
        index=text.indexOf(str,index+1);
        count++;
    }
    console.log(count);

}
function extract([text]){

    let result=[];
    let firstIndex=text.indexOf("(");
    while(firstIndex>-1){
        let secondIndex=text.indexOf(")",firstIndex+1);
        if(secondIndex==-1) break;
        let snippet=text.substring(firstIndex+1,secondIndex);
      //console.log(snippet);
        result.push(snippet);
        firstIndex=text.indexOf("(",secondIndex);
    }

    console.log(result.join(', '));
}

function practise([word,text]){

    // let result=[];
    // let count=0;
    // let firstIndex=text.indexOf("(");
    // while(firstIndex>0) {
    //     if (firstIndex == -1) break;
    //     let secondIndex = text.indexOf(")", firstIndex + 1);
    //     let word = text.slice(firstIndex + 1, secondIndex);
    //     result.push(word);
    //     count++;
    //     firstIndex = text.indexOf("(", secondIndex);
    // }
    // console.log(result.toString());
    // console.log(count);
    //////////////////////////////////////////////////////////////////
    // let count=0;
    //
    // let index=text.indexOf(word);
    // while(index>-1){
    //     if(index==-1) break;
    //     count++;
    //     index=text.indexOf(word,index+1);
    //
    // }
    // console.log(count);
    //////////////////////////////////////////////////////////////////
    let count=0;
    let lenght=word.length;
    let index=text.indexOf(word);
    console.log(index);
    while(index>-1){
        if(text[index+lenght]==" " || text[index+lenght]=="." ||
            text[index+lenght]=="!" || text[index+lenght]=="?" ||
            text[index+lenght]=="," || text[index+lenght]==")" ||text[index+lenght]=="(") count++;
        index=text.indexOf(word,index+1);
            if(index==-1) break;
        console.log(index);
    }
    console.log(count);
}

function aggrregateTable(input){

    let townsArr=[];
    let total=0;
    let price=0;
    for(let row of input){

       let townData=row.split("|");
        let name=townData[1].trim();
        townsArr.push(name);
        let price=Number(townData[2]);
        total+=price;
    }
    console.log(townsArr.join(", "));
    console.log(total);
}

function restaurant(input){
let orders=[];
    let total=0;
    for(let n=0;n<input.length;n++){
        if(n%2==0){
            orders.push(input[n]);
        }else{
            let price=Number(input[n]);
            total+=price;
        }
    }
console.log(`You purchased ${orders.join(", ")} for a total sum of ${total}`);
}
function usernames(input){
    let result=[];
    for(let email of input){
        let [name,domain]=email.split("@");
       let username=name+".";
        let domainParts=domain.split(".");
        domainParts.forEach(x=>username+=x[0]);
        result.push(username);
    }
console.log(result.join(", "));
}

function censorship(input){
    let text=input[0];
    let words=input.slice(1);
    for(let current of words){
        let replaced='-'.repeat(current.length);
        while(text.indexOf(current)>-1){
            text=text.replace(current,replaced);
        }
    }
    console.log(text);
}

function htmlInserting(items){
      let output="";
    console.log("<ul>");
        for(let n of items){
         output=htmlEscaping(n);
            console.log(" <li>"+output+"</li>");
        }
        console.log("</ul>");

    function htmlEscaping(str){

        let result="";
        for(let n of str){
            if(n=="<") result+="&lt;";
            else if(n==">") result+="&gt;";
            else if(n=="&") result+="&amp;";
            else if(n=='"') result+="&quot;";
            else if(n=="'") result+="&#39;";
            else result+=n;
        }
        //console.log(result);
        return result;
    }
}



function htmlEscaping(str){

    let result="";
    for(let n of str){
        if(n=="<") result+="&lt;";
        else if(n==">") result+="&gt;";
        else if(n=="&") result+="&amp;";
        else if(n=='"') result+="&quot;";
        else if(n=="'") result+="&#39;";
        else result+=n;
    }
   console.log(result);
    return result;
}


function matchingWords(words){
    let w=words.toString();
   w=w.split(/[\s.();+~>&"'$`:{}%!@*^#?,]+/g);;
    w.pop();
    console.log(w.join("|"));
}
function emailValidation(email) {
    let pattern=/^[a-zA-Z0-9\._]+\@[a-z]+(\.[a-z]+)+$/g;
   let result=pattern.test(email);
 if(result){
     console.log("Valid");
 }else{
     console.log("Invalid");
 }
}

function expresionSpit(words){
    let w=words.toString();
    w=w.split(/[\s.();',]+/g);
    for(let n of w)
    console.log(n);

}

function matchTheDate(text){

let pattern=/\b([0-9]{1,2})-([A-Z][a-z]{2})-([0-9]{4})\b/g;

let match;
    for(let sentence of text){
        while(match=pattern.exec(sentence)) {
            console.log(`${match[0]} (Day: ${match[1]}, Month: ${match[2]}, Year: ${match[3]})`);
        }
    }
}

function employeeData(data) {
    let pattern = /^([A-Z][a-zA-Z]*) - ([1-9][0-9]*) - ([a-zA-Z0-9 -]+)$/;


    for (let employee of data) {
        let match = pattern.exec(employee);
        if (match) {
            console.log(`Name: ${match[1]}`);
            console.log(`Position: ${match[3]}`);
            console.log(`Salary: ${match[2]}`);
        }

    }
}
function shift() {
    let fruits = ["Banana", "Orange", "Apple", "Mango"];
    let a=fruits.shift();
    console.log(a);
}

function townsToJSON(input) {
    let result=[];
    let counter=0;
    for(let n of input.slice(1)){
        result[counter]=n.split("|");
        result[counter].pop();
        result[counter].shift();
        counter++;
    }
        let result2=[];
    for(let n of result){
       if(counter!=0) {
           let f1 = n[0].trim();
           let f2 = n[1].trim();
           let f3 = n[2].trim();

           let obj = {Town:f1, Latitude:Number(f2), Longitude:Number(f3)};
           result2.push(obj);
       }
    }
    console.log(JSON.stringify(result2));
}

function scoreToHtml(input){
    let scoreArr = JSON.parse(input);
    let html="<table>\n";
        html+="   <tr><th>name</th><th>score</th></tr>\n";
    for(let score of scoreArr) {
        html += "   <tr>";
        html+=`<td>${htmlEscape(score["name"])}</td><td>${htmlEscape(score["score"])}</td>`;
        html+="</tr>\n";
    }
    html+='</table>';
    console.log(html);

    function htmlEscape(input) {
        let result="";
        input=new String(input);
        for(let n of input){
            if(n=="<") result+="&lt;";
            else if(n==">") result+="&gt;";
            else if(n=="&") result+="&amp;";
            else if(n=='"') result+="&quot;";
            else if(n=="'") result+="&#39;";
            else result+=n;
        }
        return result;
    }

}
function JSONtoHmtlTable(arr){
     let html="<table>\n";
     let str = JSON.parse(arr);
    html+="  <tr>";
    for(let obj of Object.keys(str[0])){
        html+=`<th>${htmlEscape(obj)}</th>`
    }
    html+="</tr>\n";

    for(let obj of str){
        html+="  <tr>";
        for(let atr in obj){
            html+=`<td>${htmlEscape(obj[atr])}</td>`

        }
        html+="</tr>\n";
    }
    html+="</table>";
    return html;
/////////////////////////////////////////////////////////
    function htmlEscape(input) {
        let result="";
        input=new String(input);
        for(let n of input){
            if(n=="<") result+="&lt;";
            else if(n==">") result+="&gt;";
            else if(n=="&") result+="&amp;";
            else if(n=='"') result+="&quot;";
            else if(n=="'") result+="&#39;";
            else result+=n;
        }
        return result;
    }

}

function sumByTown(data){
    let obj={ };
    let town;
    for(let i=0;i<data.length;i+=2){
        town=data[i];
        let sum=Number(data[i+1]);
        if(!obj[town]) obj[town]=0;
         obj[town]+=sum;
    }
    console.log(JSON.stringify(obj));
}

function countWords(text){
    let str=text.join('\n');
    let words=str.split(/[^A-Za-z0-9_]+/).filter(w=>w!='');
    let wordsCount={};
    for (let w of words){
        let count=0;
        if(w){
            for(let a of words)
                if(a==w)count++;
            wordsCount[w]=count;
        }
    }
    console.log(JSON.stringify(wordsCount));
}

function countWordsWithMaps(text) {
    let countWords=new Map();
    let txt=text.join('\n').toLowerCase();
    let words=txt.split(/[^A-Za-z0-9_]+/).filter(w=>w!='');
    for(let n of words){
        let count=0;
        if(n)
        {
            for(let a of words)
            {
                if(a==n) count++;
            }
        }
        countWords.set(n,count);

    }
    let allWords = Array.from(countWords.keys()).sort();
    allWords.forEach(w=> console.log(`'${w}' -> ${countWords.get(w)} times`));
}
function populationInTowns(input){
   let total=new Map();
    for(let row of input){
        let [town,pop]=row.split(/\s*<->\s*/);
        pop=Number(pop);
        if(total.has(town)){
            total.set(town,total.get(town)+pop);
        }else{
            total.set(town,pop);
        }
    }
    for (let [town, sum] of total)
        console.log(town + " : " + sum);
}
function cityMarkets(sales){
   let townsSaledProducts=new Map();
    for(let sale of sales){
        let [town,product,quantityPRICE]=sale.split(/\s*->\s*/);
        let [quantity,price]=quantityPRICE.split(/\s*:\s*/);
        if(!townsSaledProducts.has(town)){
            townsSaledProducts.set(town,new Map());
        }
        let income=quantity*price;
        let oldIncome=townsSaledProducts.get(town).get(product);
        if(oldIncome){
            income+=oldIncome;
        }
        townsSaledProducts.get(town).set(product,income);
    }
    for (let town of townsSaledProducts){
        console.log(`Town - ${town}`);
        for (let producta of town.keys()){
            console.log(`${producta[0]}:${producta[1]}`);
        }
    }
}

function agregates(arr){
    console.log("Sum ="+reduce(arr,(a,b)=>Number(a)+Number(b)));
    console.log("Min = "+reduce(arr,(a,b)=>Math.min(Number(a),Number(b))));
    console.log("Max = "+reduce(arr,(a,b)=>Math.max(Number(a),Number(b))));
    console.log("Product = "+reduce(arr,(a,b)=>Number(a)*Number(b)));
    console.log("Join = "+ reduce(arr,(a,b)=>a+b));

    function reduce(arr,func) {
        let result=arr[0];
        for(let item of arr.slice(1)){
            result=func(result,item)
        }
        return result;
    }

}
function processComands(input) {
    let commandProcessor = (function () {
        let text = "";
        return {
            append: (newText)=>text += newText,
            removeStart: (count)=>text=text.slice(count),
            removeEnd: (count)=>text=text.slice(0, text.length - count),
            print: ()=>console.log(text)
        }
    })();
    for(let cmd of input){
        let[commandName,arg]=cmd.split(" ");
        commandProcessor[commandName](arg);
    }
}

function compareRects(rectsData) {

    let rects=[];
    for(let [width,height]of rectsData){
        let rect=createRect(width,height);
        rects.push(rect);
    }
    rects.sort((a,b)=>a.compareTo(b));
    return rects;


    function createRect(width, height) {
        let rect = {
            width: width,
            height: height,
            area: ()=>rect.width * rect.height,
            compareTo: function (otherObj) {
                let result = otherObj.area() - rect.area();
                return result || (otherObj.width - rect.width)
            }
        };
        return rect;
    }
}

let fibNumbers=(function () {
    let f0=0;
    let f1=1;
    return function(){

        let oldf0=f0;
        let oldf1=f1;
        f0=f1;
        f1=oldf0+oldf1;
        return f1;
    }
})();

function command(input) {
    let commandProcessor=(function () {
        let mainText=[];
        return {
            add:(item)=>mainText.push(item),
         remove:(item)=>mainText=mainText.filter(x=>x!=item),
          print:()=>console.log(mainText)
    }})();
    for(let str of input) {
        let [command,text]=str.split(" ");
        commandProcessor[command](text);
    }
}

function sortArray(inputArray,operation){

    let sortAscending = (a,b)=>a-b;
    let sortDescending = (a,b)=>b-a;

    let sortStrategies = {
        'asc':sortAscending,
        'desc':sortDescending
    };
    //console.log(inputArray.sort(sortStrategies[operation]));
    return inputArray.sort(sortStrategies[operation]);
}
module.exports={sortArray};


function typeOfArgument(arg){
    let result=[];
    let object={};
    let commands=["string","number","function","object"];
    for(let i=0;i<arguments.length;i++){
        let argument=arguments[i];
        let obj=typeof argument;
        let counter=0;
        for(let a=0;a<arguments.length;a++){
            if(obj==typeof arguments[a]) counter++;
        }
         object[obj]=counter;
        let str=obj+": "+argument;
        result.push(str);
    }
    for(let par of commands) {
        let str2 = `${par} = ${object[par]}`;
        result.push(str2);
    }
    for (let b=0;b<result.length;b++) console.log(result[b]);
    return result;
}
class Rectangle{
    constructor(width,height,color){
        this.width=width;
        this.height=height;
        this.color=color;
    }

    toString(){
        return `${this.width},${this.height},${this.color}`;
    }
    calcArea(){
        return this.height*this.width;
}
}
function getPersons() {

    class Person {

        constructor(firstName, lastName, age, email) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.email = email;
        }

        toString() {
            return `${this.firstName} ${this.lastName} (age: ${this.age}, email: ${this.email})`
        }
    }
    return[
        new Person("Maria","Petrova",22,"mp@yahoo.com"),
        new Person('SoftUni'),
        new Person('Stephan', 'Nikolov', 25),
        new Person('Peter', 'Kolev', 24, 'ptr@gmail.com'),
    ];
}

class Circle{
    constructor(radius){
        this.radius=radius;
    }
    get diameter(){return this.radius*2;}
    set diameter(diameter){
        this.radius=diameter/2;
    }
    get area(){
        return Math.PI*this.radius*this.radius;
    }
}
// class Point{
//     constructor(x,y){
//         this.x=x;
//         this.y=y;
//     }
//  static distance(a,b){
//      const dx=a.x-b.x;
//      const dy=a.y-b.y;
//      return Math.sqrt(dx*dx+dy*dy);
//  }
//  }

 let result=(function () {

     let Suits={
          CLUBS: "\u2663",    // ♣
          DIAMONDS: "\u2666", // ♦
          HEARTS: "\u2665",   // ♥
          SPADES: "\u2660"    // ♠
     };
     let Faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];

     class Card{
        constructor(face,suit){
            this.suit=suit;
            this.face=face;
        }

         get face() { return this._face; }
         set face(face) {
             if (!Faces.includes(face))
                 throw new Error("Invalid card face: " + face);
             this._face = face;
         }
         get suit(){return this._suit}
        set suit(suit){
            if(!Object.keys(Suits).map(k=>Suits[k]).includes(suit)) throw new Error("Invalid card suit: "+suit);
            this._suit=suit;
        }
        toString(){
            return `${this.face}${this.suit}`;
        }
     }
    return {Suits,Card}
 })();



 let train=(function () {

     class Person{
         constructor(firstName,lastName,country){
             this.firstName=firstName;
             this.lastName=lastName;
             this.country=country;
         }

         get firstName(){
             return this._firstName;
         }
         set firstName(name){
             this._firstName=name;
         }

         get lastName(){
             return this._lastName;
         }
         set lastName(name){
             this._lastName=name;
         }

         get country(){
             return this._country;
         }
         set country(name){
             this._country=name;
         }

         toString(){
             return `Person: ${this.firstName} ${this.lastName} Country: ${this.country}`;
         }

     }

     class Student extends Person{
         constructor(firstName,lastName,country,grade,schoolName){
             super(firstName,lastName,country);
             this.grade=grade;
             this.schoolName=schoolName;
             Student.count=++Student.count || 1;
         }
         get grade(){
             return this._grade;
         }
         set grade(grade){
             this._grade=grade;
         }

         get schoolName(){
             return this._schoolName;
         }
         set schoolName(name){
             this._schoolName=name;
         }
         static showCount(){
             return Student.count;
         }

         toString(){
             return `${super.toString()} School's Name:${this.schoolName} Grade:${this.grade}`;
         }
     }
     return {Person,Student}
 })();
function extendClass(Class) {
    Class.prototype.species="Human";
    Class.prototype.toSpeciesString=function () {
        return `I am a ${this.species}. ${this.toString()}`
    }
}






let card=(function () {
    let faces=["2","3","4","5","6","7","8","9","10","J","Q","K","A"];
    let suits={
        "S":"\u2660",
        "H":"\u2665",
        "D":"\u2666",
        "C":"\u2663"
    };
    function checkSuits(input) {
       if(input=="S" || input=="H" || input=="D" || input=="C") return true;
       return false;

    }
    class Card {
        constructor(face,suit) {
            this.face=face;
            this.suit=suit;
        }
        get face(){
            return this._face;
        }
        set face(face){
            if (typeof face != "string") throw TypeError("Enter STRING value only!-FACES");
            if (!faces.includes(face)) throw ReferenceError("No such face in the deck!");
            this._face=face;
        }
        get suit(){
            return this._suit;
        }
        set suit(suit){
            if (typeof suit != "string") throw TypeError("Enter STRING value only!-SUITS");
            if (checkSuits(suit)==false) throw ReferenceError("No such suit in the deck!");
            this._suit=suit;
        }

        toString() {
            return  `${this.face}${suits[this.suit]}`
        }
    }
        return{Card, faces, suits}
})();

let Card=card.Card;
let c=new Card("J","D");
console.log(""+c.toString());

/**
 * Created by Grozdan on 3.12.2016 г..
 */
function sum(arr) {
    let sum = 0;
    for (num of arr)
        sum += Number(num);
    return sum;
}
function isSymmetric(arr) {
    if (!Array.isArray(arr))
        return false; // Non-arrays are non-symmetric
    let reversed = arr.slice(0).reverse(); // Clone and reverse
    let equal = (JSON.stringify(arr) == JSON.stringify(reversed));
    return equal;
}
function rgbToHexColor(red, green, blue) {
    if (!Number.isInteger(red) || (red < 0) || (red > 255))
        return undefined; // Red value is invalid
    if (!Number.isInteger(green) || (green < 0) || (green > 255))
        return undefined; // Green value is invalid
    if (!Number.isInteger(blue) || (blue < 0) || (blue > 255))
        return undefined; // Blue value is invalid
    return "#" +
        ("0" + red.toString(16).toUpperCase()).slice(-2) +
        ("0" + green.toString(16).toUpperCase()).slice(-2) +
        ("0" + blue.toString(16).toUpperCase()).slice(-2);
}
function createCalculator() {
    let value = 0;
    return {
        add: function(num) { value += Number(num); },
        subtract: function(num) { value -= Number(num); },
        get: function() { return value; }
    }
}
module.exports={sum,rgbToHexColor,isSymmetric,createCalculator};













// extendClass(Person);
// let p1=new Person("Grozdan","Andonov","Bulgaria");
// console.log(p1.toString());
// console.log(p1.toSpeciesString());
// let st=new Student("Grozdan","Andonov","Bulgaria",12,"QneSandanski");
// console.log(st.toSpeciesString());
// Object.getPrototypeOf(st).species="Drugoo";
// console.log(st.toSpeciesString());
//  let Student=train.Student;
//  let Person=train.Person;
//  let a=new Student("Grozdan","Kostadinov","Bulgaria",12,"Qne Sandanski");
//  console.log(a.showCount());
//  let b=new Student("Grozdan","Kostadinov","Bulgaria",12,"Qne Sandanski");
//  console.log(b.showCount());
//  let c=new Student("Grozdan","Kostadinov","Bulgaria",12,"Qne Sandanski");
// console.log(a.showCount());
// let d=new Person("Ivan","Petkanov","Bulgaria");
// console.log(d.toString());
/////////////////////////////////////
// let Card=result.Card;
// let Suits=result.Suits;
// let card =new Card("Q",Suits.CLUBS);
// card.face='A';
// card.suit=Suits.DIAMONDS;
// let card2=new Card("1",Suits.DIAMONDS);
////////////////////////////////////
// let p1 = new Point(5, 5);
// let p2 = new Point(10, 10);
// console.log(Point.distance(p1, p2));
//let a=getPersons().toString();
//console.log(a);
// let p1=new Person("Grozdan","Andonov",21,"grozdan96@abv.bg");
// console.log(p1);
//let redRectangle=new Rectangle(2,5,"red");
//console.log(redRectangle.toString());
 //////////////////////////////////////////////////////////////
//typeOfArgument('cat',"basket", 42, function () { console.log('Hello world!'); },{"num":23});
//sortArray([14, 7, 17, 6, 8], 'asc');
//command(['add hello','add again','remove hello','add again','print']);
//console.log(fibNumbers());
//console.log(compareRects([[3, 4], [5, 3], [3, 4], [3, 5], [12, 1]]));
//processComands((['append 123', 'append 45', 'removeStart 2', 'removeEnd 1', 'print']));
//agregates(['2','3','10','5']);
// cityMarkets(['Sofia -> Laptops HP -> 200 : 2000','Sofia -> Raspberry -> 200000 : 1500','Sofia -> Audi Q7 -> 200 : 100000','Montana -> Portokals -> 200000 : 1','Montana -> Qgodas -> 20000 : 0.2','Montana -> Chereshas -> 1000 : 0.3']);
//populationInTowns(['Sofia <-> 1200000', 'Montana <-> 20000','New York <-> 10000000','Washington <-> 2345000','Las Vegas <-> 1000000','Las Vegas <-> 44']);
//countWordsWithMaps(["Far too slow, you're far too slow."]);
//countWords(["JS devs use Node.js for server-side JS.-- JS for devs"]);
//sumByTown(['Sofia', '20', 'Varna', '3', 'Sofia', '5', 'Varna', '4']);
//JSONtoHmtlTable('[{"Name":"Tomatoes & Chips","Price":2.35},{"Name":"J&B Chocolate","Price":0.96}]');
//scoreToHtml('[{"name":"Pesho & Kiro","score":479},{"name":"Gosho, Maria & Viki","score":205}]');
//townsToJSON(['| Town | Latitude | Longitude |','| Sofia | 42.696552 | 23.32601 |','| Beijing | 39.913818 | 116.363625 |']);
//shift();
//employeeData(["Jonathan - 2000 - Manager","Peter- 1000- Chuck","George - 1000 - Team Leader"]);
//matchTheDate(['I am born on 30-Dec-1994.My father is born on the 9-Jul-1955.01-July-2000 is not a valid date.']);
//expresionSpit(['let sum = 4 * 4,b = "wow";']);
//emailValidation("invalid@emai1.bg");
//matchingWords(['A #%^ lo^#^t of@%*symbols(@i@%~n~)`this......sentence...123456789*&%#0:"">>?:{{!@#@@#$%The+_)(*&^%$#@!End.']);
//htmlEscaping('Hello, <script>alert("Injected JS code")</script>');
//censorship(['I like C#, HTML, JS and PHP','C#', 'HTML', 'PHP']);
//usernames(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com']);
//restaurant(['Beer Zagorka', '2.65', 'Tripe soup', '7.80','Lasagna', '5.69']);
//aggrregateTable(['| Sofia           | 300', '| Veliko Tarnovo  | 500', '| Yambol          | 275']);
//practise(["Grozdan",'I  .DAGrozdan.  amd m much Grozdanadad) amore GrozdanGSFSAF!'])
//extract(["Rakiya (Bulgarian brandy) is home-made liquor (alcoholic drink). It can be made of grapes, plums or other fruits (even apples)."]);
//countOccurrences((['mam', 'I mam cool mamam']));
//concatReverse(['aidee','na','moretoo']);
//stringCount(["SoftUni"]);
//lastKsequence(['2', '7', '8', '9']);
//NandPnums(['3', '-2', '0', '-1']);
//evenShow(['5', '10']);
//sumFurtLast(['5', '10']);
//agregateElements(['2', '4', '8', '16']);
//calcNums(["1","-1","-"]);
//dayOfWeek("Monday");
//isPalindrom(["unitinu"]);
//squareOfStars(5);
//triangleOfStars(4);
//distance3D([1, 1, 0, 5, 4, 0]);
//distanceTime([11, 10, 120]);
//areaAndPerimetter([2.5,3.14]);
//greetings("G");
//primeChecher(81);
//logarithum(["1024","1048576","256","2","1"]);
//document.body.innerHTML=evenOrOdd([10]);
//fruitOrVegetable("asdaa");
//OddOrEven("6.5");
//copeAreaVolume(["3","5"]);
//triangleArea(["2","3.5","4"]);
//circleArea("5");
//leapYear("1900");
// bottles(['20','6']);
//multiply(['23632.36','-12.3249']);
// distanceBetween2points(['2.34', '15.66', '-13.55', '-2.9985']);
// nextDay(['2016', '10', '31']);
// areaValue(['2', '4', '5', '3']);
//concatNum('14');
// nameAndAge('18', 'Ivan', '15', 'Asen', '22');
// letterCounter("GrozdanAndonov",'o')
// sumAndVat(['1.20','2.60','3.50']);

