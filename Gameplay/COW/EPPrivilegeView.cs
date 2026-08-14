using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003378")]
public class EPPrivilegeView : MonoBehaviour
{
	[Token(Token = "0x4013992")]
	[FieldOffset(Offset = "0xC")]
	public UIButton m_Privilege1;

	[Token(Token = "0x4013993")]
	[FieldOffset(Offset = "0x10")]
	public UIButton m_Privilege2;

	[Token(Token = "0x4013994")]
	[FieldOffset(Offset = "0x14")]
	public UIButton m_Privilege3;

	[Token(Token = "0x6015E1C")]
	[Address(RVA = "0x251A2E8", Offset = "0x251A2E8", VA = "0x251A2E8")]
	public EPPrivilegeView()
	{
	}

	[Token(Token = "0x6015E1D")]
	[Address(RVA = "0x251A2F0", Offset = "0x251A2F0", VA = "0x251A2F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6015E1E")]
	[Address(RVA = "0x251A600", Offset = "0x251A600", VA = "0x251A600")]
	private void onClickPrivilege1()
	{
	}

	[Token(Token = "0x6015E1F")]
	[Address(RVA = "0x251A924", Offset = "0x251A924", VA = "0x251A924")]
	private void onClickPrivilege2()
	{
	}

	[Token(Token = "0x6015E20")]
	[Address(RVA = "0x251A9F0", Offset = "0x251A9F0", VA = "0x251A9F0")]
	private void onClickPrivilege3()
	{
	}

	[Token(Token = "0x6015E21")]
	[Address(RVA = "0x251A6CC", Offset = "0x251A6CC", VA = "0x251A6CC")]
	private void ShowPrivilegeDescTips(UIButton parent, string titleKey, string tipsKey)
	{
	}
}
