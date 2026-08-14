using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000AAF")]
internal class CustomPathCrossHair : SceneEditCrosshair
{
	[Token(Token = "0x4005D5D")]
	[FieldOffset(Offset = "0xAC")]
	private UGCLevelCustomPath KODCHLOJNCO;

	[Token(Token = "0x4005D5E")]
	[FieldOffset(Offset = "0xB0")]
	private uint OBMLPMMIOGP;

	[Token(Token = "0x4005D5F")]
	[FieldOffset(Offset = "0xB4")]
	public uint PointIntervalDistance;

	[Token(Token = "0x4005D60")]
	[FieldOffset(Offset = "0xB8")]
	public List<GameObject> ControlPoints;

	[Token(Token = "0x4005D61")]
	[FieldOffset(Offset = "0xBC")]
	public List<GameObject> CachedControlPoints;

	[Token(Token = "0x60051B7")]
	[Address(RVA = "0x1E9E86C", Offset = "0x1E9E86C", VA = "0x1E9E86C")]
	public CustomPathCrossHair()
	{
	}

	[Token(Token = "0x60051B8")]
	[Address(RVA = "0x1E9E91C", Offset = "0x1E9E91C", VA = "0x1E9E91C", Slot = "4")]
	public override void Init(SceneEditAgent CCJEIDKEBJL, SceneEditPrefabConfigData JHENJMANOEL)
	{
	}

	[Token(Token = "0x60051B9")]
	[Address(RVA = "0x1E9EA48", Offset = "0x1E9EA48", VA = "0x1E9EA48")]
	public void UpdatePointCount(int BLEAICPKPGL)
	{
	}

	[Token(Token = "0x60051BA")]
	[Address(RVA = "0x1E9F0C0", Offset = "0x1E9F0C0", VA = "0x1E9F0C0")]
	private void IHJJGFJCIIK(GameObject JBKIMCBCCMF, bool JBPPGEAJPNL)
	{
	}

	[Token(Token = "0x60051BB")]
	[Address(RVA = "0x1E9F230", Offset = "0x1E9F230", VA = "0x1E9F230")]
	private GameObject FDAEKMNFIPF(int HHLONFLCJBL)
	{
		return null;
	}

	[Token(Token = "0x60051BC")]
	[Address(RVA = "0x1E9FA10", Offset = "0x1E9FA10", VA = "0x1E9FA10")]
	private void CFEFGEILMHA()
	{
	}

	[Token(Token = "0x60051BD")]
	[Address(RVA = "0x1E9FCD8", Offset = "0x1E9FCD8", VA = "0x1E9FCD8", Slot = "6")]
	public override void InheritDataFromCrosshairToSceneEditObject(SceneEditObjectBase ECINOMEHBKA)
	{
	}

	[Token(Token = "0x60051BE")]
	[Address(RVA = "0x1EA00FC", Offset = "0x1EA00FC", VA = "0x1EA00FC")]
	public void _003C_003EiFixBaseProxy_Init(SceneEditAgent P0, SceneEditPrefabConfigData P1)
	{
	}

	[Token(Token = "0x60051BF")]
	[Address(RVA = "0x1EA0104", Offset = "0x1EA0104", VA = "0x1EA0104")]
	public void _003C_003EiFixBaseProxy_InheritDataFromCrosshairToSceneEditObject(SceneEditObjectBase P0)
	{
	}
}
