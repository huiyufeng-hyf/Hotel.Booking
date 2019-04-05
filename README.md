# Hotel.Booking
A simple OOP sample for booking hotel based on file input.

REQUIREMENT:
A company own different brand of hotels, which have different brand name, hotel service level and capacity of rooms. When client booking the hotel based on their needs, the program should display booking result info.
If order is valid, then display the order info with client name, hotel brand name and booking room count, otherwise, display result of "Invalid".

Here are the prerequisites info:
<table>
	<thead>
		<tr>
			<td>Brand</td>
			<td>Level</td>
			<td>Rooms</td>
		</tr>
	</thead>
	<tbody>
		<tr>
			<td>JW</td>
			<td>*****(5 star)</td>
			<td>400</td>
		</tr>
		<tr>
			<td>KQ</td>
			<td>****</td>
			<td>450</td>
		</tr>
		<tr>
			<td>LR</td>
			<td>***</td>
			<td>420</td>
		</tr>
		<tr>
			<td>HT</td>
			<td>**</td>
			<td>200</td>
		</tr>
	</tbody>
</table>
Here are the sample orders input from file stream (with format of "ClientName BrandName Check-In-Date Check-Out-Date BookingRooms"):
AAA JW 2019-04-05 2019-04-10 300<br/>
BBB JW 2019-04-05 2019-04-07 100<br/>
CCC LR 2019-04-01 2019-04-05 200<br/>

Here are some test cases with expected output result:
AAA JW 2019-04-01 2019-04-02 380
Output:
AAA JW 380

AAA JW 2019-04-05 2019-04-10 401
Output:
Invalid

AAA JW 2019-04-01 2019-04-02 380
BBB JW 2019-04-02 2019-04-04 21
Output:
Invalid

AAA JW 2019-04-01 2019-04-02 380
BBB JW 2019-04-03 2019-04-04 21
CCC KQ 2019-04-03 2019-04-04 450
Output:
AAA JW 380
BBB JW 21
CCC KQ 450
