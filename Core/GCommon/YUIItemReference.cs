using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200417B")]
public class YUIItemReference : MonoBehaviour
{
	[Token(Token = "0x401B75A")]
	[FieldOffset(Offset = "0xC")]
	public List<YUIItemVariable> itemVarList;

	[Token(Token = "0x601AC13")]
	[Address(RVA = "0x2BDC4FC", Offset = "0x2BDC4FC", VA = "0x2BDC4FC")]
	public YUIItemReference()
	{
	}

	[Token(Token = "0x601AC14")]
	[Address(RVA = "0x2BDC504", Offset = "0x2BDC504", VA = "0x2BDC504")]
	public bool IsExistItem(Transform target)
	{
		return default(bool);
	}

	[Token(Token = "0x601AC15")]
	[Address(RVA = "0x2BDC6E0", Offset = "0x2BDC6E0", VA = "0x2BDC6E0")]
	public YUIItemVariable GetItem(Transform target)
	{
		return null;
	}

	[Token(Token = "0x601AC16")]
	[Address(RVA = "0x2BDC950", Offset = "0x2BDC950", VA = "0x2BDC950")]
	public void RemoveItem(YUIItemVariable item)
	{
	}
}
