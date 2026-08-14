using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000D02")]
internal interface LNPFNEMBDOB : _Attribute
{
	[Token(Token = "0x17000842")]
	bool JCAPJNOALJN
	{
		[Token(Token = "0x60062F8")]
		get;
	}

	[Token(Token = "0x17000843")]
	bool NJHDBLDLGGI
	{
		[Token(Token = "0x60062F9")]
		get;
	}

	[Token(Token = "0x17000844")]
	Action EKCKLLNLEEO
	{
		[Token(Token = "0x6006304")]
		set;
	}

	[Token(Token = "0x17000845")]
	Action EOLLAHNPEHI
	{
		[Token(Token = "0x6006305")]
		set;
	}

	[Token(Token = "0x60062FA")]
	void Init(BCIGOPJHDPB AJKBOONEOAB, Transform PKJDJAEEMFA, bool JGAKJHAPHOA);

	[Token(Token = "0x60062FB")]
	void OnGetOn(Player PJOIFFLCDPM);

	[Token(Token = "0x60062FC")]
	void OnGetOff(Player PJOIFFLCDPM);

	[Token(Token = "0x60062FD")]
	void SetVisible(bool KENDCFNPDCE);

	[Token(Token = "0x60062FE")]
	void Jump();

	[Token(Token = "0x60062FF")]
	void StopJump();

	[Token(Token = "0x6006300")]
	void Dash();

	[Token(Token = "0x6006301")]
	void StopDash();

	[Token(Token = "0x6006302")]
	void ApplyAxisControl(Vector3 LLJJKBAGKHP);

	[Token(Token = "0x6006303")]
	void OnForceSync(Vector3 FAFEDEPIFIF);
}
