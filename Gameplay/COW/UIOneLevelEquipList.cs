using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020EB")]
public class UIOneLevelEquipList : MonoBehaviour
{
	[Token(Token = "0x400CDE1")]
	[FieldOffset(Offset = "0xC")]
	public UIGrid Grid;

	[Token(Token = "0x400CDE2")]
	[FieldOffset(Offset = "0x10")]
	public UILabel LevelLabel;

	[Token(Token = "0x400CDE3")]
	[FieldOffset(Offset = "0x14")]
	public GameObject LockMask;

	[Token(Token = "0x400CDE4")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> BonusItemLevelIcon;

	[Token(Token = "0x400CDE5")]
	[FieldOffset(Offset = "0x1C")]
	public List<GameObject> BonusItemLevelIcon2;

	[Token(Token = "0x600AA8F")]
	[Address(RVA = "0x159E98C", Offset = "0x159E98C", VA = "0x159E98C")]
	public UIOneLevelEquipList()
	{
	}
}
