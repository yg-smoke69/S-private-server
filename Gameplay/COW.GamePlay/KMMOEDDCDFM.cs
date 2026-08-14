using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000C16")]
public interface KMMOEDDCDFM
{
	[Token(Token = "0x170007DC")]
	List<IPIKJNGGEOB> DAJDOGOPJKI
	{
		[Token(Token = "0x6005C6C")]
		get;
	}

	[Token(Token = "0x170007DD")]
	Vector2 AEOEMDPAGHB
	{
		[Token(Token = "0x6005C6D")]
		get;
		[Token(Token = "0x6005C6E")]
		set;
	}

	[Token(Token = "0x170007DE")]
	UISprite EMJGFDPBDLK
	{
		[Token(Token = "0x6005C6F")]
		get;
	}

	[Token(Token = "0x170007DF")]
	Transform GEEGEDPOLAH
	{
		[Token(Token = "0x6005C70")]
		get;
	}

	[Token(Token = "0x170007E0")]
	EJPDJDBMLIN EKDOECAENMH
	{
		[Token(Token = "0x6005C71")]
		get;
	}

	[Token(Token = "0x170007E1")]
	BoxCollider ALDDOJNFKBN
	{
		[Token(Token = "0x6005C72")]
		get;
	}

	[Token(Token = "0x6005C73")]
	void UpdateColorAndBG(Color MGAOFBNFAKF);

	[Token(Token = "0x6005C74")]
	void SetHeaderWidghtDepth(int KBMHNKKGDAN, bool CHHEGOKPMPD = true);

	[Token(Token = "0x6005C75")]
	void UpdateHeaderSize();
}
