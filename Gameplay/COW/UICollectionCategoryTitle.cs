using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200214D")]
public class UICollectionCategoryTitle : MonoBehaviour, _Attribute
{
	[Token(Token = "0x400D123")]
	[FieldOffset(Offset = "0xC")]
	public UILabel Name;

	[Token(Token = "0x600AFB5")]
	[Address(RVA = "0x2CD3548", Offset = "0x2CD3548", VA = "0x2CD3548")]
	public UICollectionCategoryTitle()
	{
	}

	[Token(Token = "0x600AFB6")]
	[Address(RVA = "0x2CD3550", Offset = "0x2CD3550", VA = "0x2CD3550", Slot = "5")]
	public void SetPosition(Vector2 position)
	{
	}

	[Token(Token = "0x600AFB7")]
	[Address(RVA = "0x2CD3678", Offset = "0x2CD3678", VA = "0x2CD3678", Slot = "4")]
	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	[Token(Token = "0x600AFB8")]
	[Address(RVA = "0x2CD3784", Offset = "0x2CD3784", VA = "0x2CD3784", Slot = "6")]
	public void SetTable2Visible(bool visible)
	{
	}
}
