using System.Collections.Generic;
using COW.Gameplay.UGC.BlockEdit;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000BBB")]
public interface EKEOCIDDIFH
{
	[Token(Token = "0x1700075D")]
	Transform AAPOHEDPNDG
	{
		[Token(Token = "0x6005921")]
		get;
	}

	[Token(Token = "0x1700075E")]
	List<IPIKJNGGEOB> NFPIJCAFMMJ
	{
		[Token(Token = "0x6005922")]
		get;
		[Token(Token = "0x6005923")]
		set;
	}

	[Token(Token = "0x1700075F")]
	BE_BlockSectionHeader_Slot HHLBJOKMMGC
	{
		[Token(Token = "0x6005924")]
		get;
		[Token(Token = "0x6005925")]
		set;
	}

	[Token(Token = "0x17000760")]
	BE_DataSpot CIMOEHHKHIK
	{
		[Token(Token = "0x6005926")]
		get;
	}

	[Token(Token = "0x17000761")]
	UIWidget FOGAGIPGMMI
	{
		[Token(Token = "0x6005927")]
		get;
	}

	[Token(Token = "0x17000762")]
	UISprite KIIGJMBCKDO
	{
		[Token(Token = "0x6005928")]
		get;
	}

	[Token(Token = "0x17000763")]
	List<BE_SlotDragDropItem> IMIHMFHDOLM
	{
		[Token(Token = "0x6005929")]
		get;
	}

	[Token(Token = "0x17000764")]
	UISprite MOEGALPADFK
	{
		[Token(Token = "0x600592A")]
		get;
	}

	[Token(Token = "0x17000765")]
	BlockData CLCFBJIKGBN
	{
		[Token(Token = "0x600592F")]
		get;
		[Token(Token = "0x6005930")]
		set;
	}

	[Token(Token = "0x17000766")]
	bool NBAFOEGLFAE
	{
		[Token(Token = "0x6005931")]
		get;
		[Token(Token = "0x6005932")]
		set;
	}

	[Token(Token = "0x600592B")]
	void UpdateSize();

	[Token(Token = "0x600592C")]
	void SetBGAndColor(Color MGAOFBNFAKF);

	[Token(Token = "0x600592D")]
	void SetBlockWidghtDepth(int KBMHNKKGDAN, bool CHHEGOKPMPD = true);

	[Token(Token = "0x600592E")]
	void UpdateDataBlockSize();

	[Token(Token = "0x6005933")]
	void SetHighLightState(bool GLDLCOBLGNF);
}
