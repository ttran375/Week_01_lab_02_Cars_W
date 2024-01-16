### Submission: See course shell for how and when to submit.

# Creating a Car class

A class is a self-contained piece of software that can function on its
own.

Apology: UML and some newer languages specify the type after the
identifier. C# on the other hand requires that you specify the type and
then the identifier.

We will model a car in software.

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><p><strong>Car</strong></p>
<p>Class</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Fields</strong></td>
</tr>
<tr class="even">
<td><blockquote>
<p>- year : int</p>
<p>- model : string</p>
<p>- isDrivable : bool</p>
<p>- price : double</p>
</blockquote></td>
</tr>
<tr class="odd">
<td><strong>Methods</strong></td>
</tr>
<tr class="even">
<td><blockquote>
<p>+ «constructor» Car(</p>
<p>year : int,</p>
<p>model : string,</p>
<p>price : double,</p>
<p>isDrivable : bool = true)</p>
<p>+ ToString() : string</p>
</blockquote></td>
</tr>
</tbody>
</table>

## Description of field members:

1.  **year**: this private member represents the year value of this
    object

2.  **model**: this private member represents the model of this car

3.  **isDrivable**: this private member indicates if this car be driven

4.  **price**: this private member represents the selling price of this
    car

To restrict access, fields are normally decorated with the private
modifier.

## Constructor:

1.  **<span class="mark">public Car(string model, int year, double
    price, bool isDrivable = true)</span>**: this is the constructor of
    this class. It takes five arguments and assigns them to the
    appropriate fields. You will assume that all the arguments will be
    sane (i.e. the values will not break your program).

Having a default argument is a common wat to simplify class usage.

## Description of action member:

1.  **<span class="mark">public override string ToString()</span>**:
    this method overrides the same method in the base class. It does not
    take any argument but it returns a string representing this object.
    You get to decide how the output will look like. It is expected that
    all the values be displayed.

The code to test or exercise your application is called a Test Harness.

In your main method write the code to do the following:

1.  Create at least four cars and print them. Remember to call the
    constructor with 4 or 5 parameters.
