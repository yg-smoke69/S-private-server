using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001ECA")]
public class UIDigitaluniverseBGalaxyGroupLevelView : MonoBehaviour
{
	[Token(Token = "0x400C1E5")]
	[FieldOffset(Offset = "0xC")]
	private int GROUPNUM;

	[Token(Token = "0x400C1E6")]
	[FieldOffset(Offset = "0x10")]
	public GameObject m_GroupView1;

	[Token(Token = "0x400C1E7")]
	[FieldOffset(Offset = "0x14")]
	public GameObject m_GroupView2;

	[Token(Token = "0x400C1E8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject m_GroupView3;

	[Token(Token = "0x400C1E9")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject m_GroupView4;

	[Token(Token = "0x400C1EA")]
	[FieldOffset(Offset = "0x20")]
	private List<GameObject> m_ListGroups;

	[Token(Token = "0x60095C5")]
	[Address(RVA = "0x2F644C8", Offset = "0x2F644C8", VA = "0x2F644C8")]
	public UIDigitaluniverseBGalaxyGroupLevelView()
	{
	}

	[Token(Token = "0x60095C6")]
	[Address(RVA = "0x2F6459C", Offset = "0x2F6459C", VA = "0x2F6459C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60095C7")]
	[Address(RVA = "0x2F64820", Offset = "0x2F64820", VA = "0x2F64820")]
	public GameObject GetGroupView(int groupIndex)
	{
		return null;
	}
}
