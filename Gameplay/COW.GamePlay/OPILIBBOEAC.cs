using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000411")]
internal interface OPILIBBOEAC
{
	[Token(Token = "0x170001BC")]
	GameObject JHICBALKJHC
	{
		[Token(Token = "0x60013F4")]
		get;
	}

	[Token(Token = "0x170001BD")]
	Vector3 CCIKDFGDBAM
	{
		[Token(Token = "0x60013F5")]
		get;
	}

	[Token(Token = "0x170001BE")]
	Quaternion CCDDHEBKMGD
	{
		[Token(Token = "0x60013F6")]
		get;
	}

	[Token(Token = "0x170001BF")]
	bool NPFKJJDEIEG
	{
		[Token(Token = "0x60013F9")]
		get;
	}

	[Token(Token = "0x170001C0")]
	Collider ADMPENNANLN
	{
		[Token(Token = "0x60013FF")]
		get;
		[Token(Token = "0x6001400")]
		set;
	}

	[Token(Token = "0x60013F7")]
	bool IsVisible();

	[Token(Token = "0x60013F8")]
	bool IsStreamerVisible();

	[Token(Token = "0x60013FA")]
	uint GetAttackableID();

	[Token(Token = "0x60013FB")]
	JADJBFDFEHA GetAttackableType();

	[Token(Token = "0x60013FC")]
	float GetAttackableRadius();

	[Token(Token = "0x60013FD")]
	Vector3 GetAttackableCenterWS();

	[Token(Token = "0x60013FE")]
	Vector3 GetHitDamagePos();

	[Token(Token = "0x6001401")]
	bool NeedAssit();

	[Token(Token = "0x6001402")]
	bool CanAssitByWeapon(Player DEKAHNJALPI, GPBDEDFKJNA LPGPKFMGCBG);

	[Token(Token = "0x6001403")]
	bool IsSameTeamWithPlayerID(IHAAMHPPLMG FGFGBHLEONO);

	[Token(Token = "0x6001404")]
	void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint EMFANFHKAMM = 0u);

	[Token(Token = "0x6001405")]
	void TakeHealing(int EDEOPLNOGPP, IHAAMHPPLMG ONPMGNIIMJD, int OIFJAJJFBLK, [Optional] Vector3 NJMFBKNHMBP, [Optional] Vector3 DOBOBMFMKBJ, [Optional] List<float> NBKBEBFNDBE);
}
