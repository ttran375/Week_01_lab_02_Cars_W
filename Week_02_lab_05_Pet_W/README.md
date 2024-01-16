### Submission: See course shell for how and when to submit

You will practice working with properties and using List.

# Creating a Pet class

Create the following class

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><p><strong>Pet</strong></p>
<p>Class</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Properties</strong></td>
</tr>
<tr class="even">
<td><blockquote>
<p>+ «property setter absent» Name :
<strong><mark>string</mark></strong></p>
<p>+ «property setter private» Owner :
<strong><mark>string</mark></strong></p>
<p>+ «property setter absent» Age :
<strong><mark>int</mark></strong></p>
<p>+ «property setter absent» Description :
<strong><mark>string</mark></strong></p>
<p>+ «property setter private» IsHouseTrained :
<strong><mark>bool</mark></strong></p>
</blockquote></td>
</tr>
<tr class="odd">
<td><strong>Methods</strong></td>
</tr>
<tr class="even">
<td><blockquote>
<p>+ «constructor» Pet(</p>
<p>name : <strong><mark>string</mark></strong>,</p>
<p>age : <strong><mark>int</mark></strong>,</p>
<p>description : <strong><mark>string</mark></strong>)</p>
<p>+ ToString() : <strong><mark>string</mark></strong></p>
<p>+ Train() : <strong><mark>void</mark></strong></p>
<p>+ SetOwner(newOwner : <strong><mark>string</mark></strong>) :
<strong><mark>void</mark></strong></p>
</blockquote></td>
</tr>
</tbody>
</table>

## Description of members:

##### Fields: 

> There are no fields.

##### Properties:

1.  The properties are self-explanatory. The getter is public and the
    setter is mostly absent.

##### Constructor:

1.  **<span class="mark">public</span>
    Pet(<span class="mark">string</span> name,
    <span class="mark">int</span> age, <span class="mark">string</span>
    description) –** This constructor takes three arguments and assigns
    them to the appropriate properties. It also initializes the fields
    owner to “no one” and **isHousedTrained** to
    **<span class="mark">false</span>**

Remember the ToString() method is needed to produce a sensible output on
the screen

##### Methods:

1.  **<span class="mark">public override string ToString()</span>** –
    This method returns a string fully describing this object.

2.  **<span class="mark">public void SetOwner(string</span>
    owner<span class="mark">)</span>** – This method simply assigns the
    argument to the appropriate field.

3.  **<span class="mark">public void Train()</span>** – This method sets
    the property IsHouseTrained to **<span class="mark">true</span>**.

## Test Harness

In your main method write the code to do the following:

1.  Create four objects. You decide on the arguments

2.  Create a List to store all the above objects.

3.  Use some of the methods on some of the objects.

4.  Using a suitable looping statement, display all the objects in the
    collection.

5.  Prompt the user for an owner’s name and then display only the pets
    belonging to a particular person.