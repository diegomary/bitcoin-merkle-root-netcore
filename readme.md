bitcoin-merkle-root 
====================
Using package manager console
Install-Package merkleroot -Version 1.0.4

The algorithm doesn’t use recursion anymore so there shouldn’t be any stack
overflow for big sets of transactions hashes

 

`using merkleroot;`

`console.WriteLine(merkle.BitcoinMerkleRoot(tx))`

where tx is an array of bitcoin transactions.

To demonstrate the usage of this utility let’s consider the following Bitcoin
Block in Testnet:

[Bitcoin Testnet Block
1288511](https://testnet.blockchain.info/block/00000000f47381bc197925d40088e60786e567be678d2770c582d4c115ead284)

 

The cited block has 21 transactions:

 

We can create an array of transaction hashes copying them from the website as
follows:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
string[] tx ={
"fd636107ceb6de2486331ad662955d09abf0414079f2ea59f12da2cfa15c4561",
"088b7d88355a96633fb9586806d75d9c7e6e08b8ddaea8155f4be5ef180df3a7",
"dee47a1af1fbdc1ea8415ad046677234b008aac1a1f46365c5b59a33eca48065",
"126dbb8968504661d68adfdee5d969993e9d5262900b40ba10a92b7403e33164",
"9014543cdfe4f59d03f3e58d0e3cd34b1205e3173080d6252ba2c4d19977b672",
"ab41defef0fd2929868848dd853087e39544772b3469812d3530dc7a93604fd4",
"4ab90706d1162c6ef46bf7f4ab6a39cfae2f47a939a33bb9aed31e3bbe3bd86e",
"c6475296a18ad0423dacc3a94a231a60609f34ff068b7374880a42cbc5316307",
"4059bab2ec2255c0fe0c74afc774cefbbfddb1073745f6f9469c5545938f4891",
"e1622b99c933d518389f1793cac5fe482e5a6e8835d4803bb5deb60634fbc7bd",
"965fc983603545eab3571170940bb77fc301bdd02d4703504f580fdcf57abbfd",
"49f0f8198def669faefe2a9b30310edbd96ee685ea46e91c7a694863dcfa6c40",
"3751b0c8ea70985bcefbe0fd57e5977af32484a80a3bc6c96002ef94782e502b",
"33bb6d11961394dfa6262ca0a9e7d8ef8a090d02486be0067a0eea2462fc53b0",
"44195b102d6adf310530be98c9f216450bb66849030dc37a1bb832a3b1f0aa49",
"890756e5b2010f0a2514155450c9c1a40a5cfcd0f8f863b8820edbd93cb804ef",
"032a93ec78dfa141671e39bc482068d833f8ecf0c1c3daf580fcf97815a37e25",
"fd21f47e89e9bd3dca07e6d8274a49e7838ac8851e96228102f31fd1a7dd755f",
"69d184c03a2ca64a8ddfc84839f7dd71c66ec5a8ecde726e8834bfd71c3ae496",
"57aad7b35748c1d494240b3f4eaad3edd28edcfd645de4cb04aa430b2b870ca5",
"80f5f39bf798a2a13338cbe4f71aaca2c155e5fc9f97b50ca83e770e98deba90"
}
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 

The Merkle root Hash can be seen in the page and its value is:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Merkle Root: a17a4959eacfae4f3e06c4129c87e627ce6fe93987e78b66999a38e684c6fed5
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 

If we use the utility we can write:

`console.WriteLine(merkle.BitcoinMerkleRoot(tx))`;

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
output: 

a17a4959eacfae4f3e06c4129c87e627ce6fe93987e78b66999a38e684c6fed5
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 
