using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000D34")]
internal class WereWolvesRolePawn : ReusableObject, _Attribute
{
	[Token(Token = "0x4006ABD")]
	[FieldOffset(Offset = "0x18")]
	public float PawnHeight;

	[Token(Token = "0x4006ABE")]
	[FieldOffset(Offset = "0x1C")]
	public Material SoulMat;

	[Token(Token = "0x4006ABF")]
	[FieldOffset(Offset = "0x20")]
	public Transform BipBoneTransform;

	[Token(Token = "0x4006AC0")]
	[FieldOffset(Offset = "0x24")]
	private Animation KJCDHHOEGCH;

	[Token(Token = "0x4006AC1")]
	[FieldOffset(Offset = "0x28")]
	private SkinnedMeshRenderer NHAHGEDAJHG;

	[Token(Token = "0x4006AC2")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<string, Transform> MILLMPIFAIA;

	[Token(Token = "0x6006529")]
	[Address(RVA = "0x26F678C", Offset = "0x26F678C", VA = "0x26F678C")]
	public WereWolvesRolePawn()
	{
	}

	[Token(Token = "0x600652A")]
	[Address(RVA = "0x26F679C", Offset = "0x26F679C", VA = "0x26F679C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600652B")]
	[Address(RVA = "0x26F68C0", Offset = "0x26F68C0", VA = "0x26F68C0", Slot = "8")]
	public GameObject GameObject()
	{
		return null;
	}

	[Token(Token = "0x600652C")]
	[Address(RVA = "0x26F6924", Offset = "0x26F6924", VA = "0x26F6924", Slot = "6")]
	public void OnEnterTransform()
	{
	}

	[Token(Token = "0x600652D")]
	[Address(RVA = "0x26F69AC", Offset = "0x26F69AC", VA = "0x26F69AC", Slot = "7")]
	public void OnExitTransform()
	{
	}

	[Token(Token = "0x600652E")]
	[Address(RVA = "0x26F6A44", Offset = "0x26F6A44", VA = "0x26F6A44", Slot = "9")]
	public void SetColliderEnable(bool MCDIDHODHLN, int NFIFPONEOID)
	{
	}

	[Token(Token = "0x600652F")]
	[Address(RVA = "0x26F6AB4", Offset = "0x26F6AB4", VA = "0x26F6AB4", Slot = "10")]
	public Transform GetBoneByName(string IBGJHGFMNBM)
	{
		return null;
	}

	[Token(Token = "0x6006530")]
	[Address(RVA = "0x26F6CE4", Offset = "0x26F6CE4", VA = "0x26F6CE4", Slot = "11")]
	public bool IsUseTransformCameraBackOffset()
	{
		return default(bool);
	}

	[Token(Token = "0x6006531")]
	[Address(RVA = "0x26F6D3C", Offset = "0x26F6D3C", VA = "0x26F6D3C", Slot = "12")]
	public void SetUseTransformCameraBackOffset(bool FGODFHOKEAP)
	{
	}

	[Token(Token = "0x6006532")]
	[Address(RVA = "0x26F6D98", Offset = "0x26F6D98", VA = "0x26F6D98")]
	public void PlayAnim(string FIHEJIKOFMM)
	{
	}

	[Token(Token = "0x6006533")]
	[Address(RVA = "0x26F6ECC", Offset = "0x26F6ECC", VA = "0x26F6ECC")]
	public void SetVisible(bool FKHMOFHBOCC)
	{
	}

	[Token(Token = "0x6006534")]
	[Address(RVA = "0x26F6F5C", Offset = "0x26F6F5C", VA = "0x26F6F5C")]
	public void ChangeToDeadMode()
	{
	}
}
