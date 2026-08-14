using System.Runtime.InteropServices;
using COW.Gameplay.LevelObject;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x200072D")]
public class UGCLevelTrigger : LevelUGCCustomizeTrigger, _Attribute
{
	[Token(Token = "0x4004C7A")]
	[FieldOffset(Offset = "0x7C")]
	private GameObject DALEGKNDKOK;

	[Token(Token = "0x4004C7B")]
	[FieldOffset(Offset = "0x80")]
	public GameObject HideIconPrefeb;

	[Token(Token = "0x4004C7C")]
	[FieldOffset(Offset = "0x84")]
	private GameObject CJNJKCKEOKG;

	[Token(Token = "0x6002D82")]
	[Address(RVA = "0x138D388", Offset = "0x138D388", VA = "0x138D388")]
	public UGCLevelTrigger()
	{
	}

	[Token(Token = "0x6002D83")]
	[Address(RVA = "0x138D390", Offset = "0x138D390", VA = "0x138D390")]
	private ResourceID ANOLNEIDJNM(OMDNLEEOJBD DIPOHFNABKH)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002D84")]
	[Address(RVA = "0x138D4B4", Offset = "0x138D4B4", VA = "0x138D4B4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002D85")]
	[Address(RVA = "0x138D558", Offset = "0x138D558", VA = "0x138D558")]
	public void UpdateTriggerInfo(OMDNLEEOJBD DIPOHFNABKH, bool OGAFCJBHMFK, bool JHDBLHIKCNO, bool AIOHEJMJKHP)
	{
	}

	[Token(Token = "0x6002D86")]
	[Address(RVA = "0x138DBC0", Offset = "0x138DBC0", VA = "0x138DBC0", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002D87")]
	[Address(RVA = "0x138DCE8", Offset = "0x138DCE8", VA = "0x138DCE8")]
	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002D88")]
	[Address(RVA = "0x138DCF0", Offset = "0x138DCF0", VA = "0x138DCF0")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
