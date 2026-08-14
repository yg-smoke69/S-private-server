using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

[Token(Token = "0x2000891")]
internal class PetsPawn : MonoBehaviour, _Attribute, IConvertible
{
	[Token(Token = "0x400534B")]
	[FieldOffset(Offset = "0xC")]
	public float PawnHeight;

	[Token(Token = "0x400534C")]
	[FieldOffset(Offset = "0x10")]
	public List<PetAnimation> animationList;

	[Token(Token = "0x400534D")]
	[FieldOffset(Offset = "0x14")]
	public Transform BipBoneTransform;

	[Token(Token = "0x400534E")]
	[FieldOffset(Offset = "0x18")]
	private uint skinID;

	[Token(Token = "0x400534F")]
	[FieldOffset(Offset = "0x1C")]
	private Animation m_Animation;

	[Token(Token = "0x4005350")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID WalkSFXResId;

	[Token(Token = "0x4005351")]
	[FieldOffset(Offset = "0x24")]
	public float AnimationBaseSpeed;

	[Token(Token = "0x4005352")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, Transform> m_Bones;

	[Token(Token = "0x6003C11")]
	[Address(RVA = "0x1C79D30", Offset = "0x1C79D30", VA = "0x1C79D30")]
	public PetsPawn()
	{
	}

	[Token(Token = "0x6003C12")]
	[Address(RVA = "0x1C79DC8", Offset = "0x1C79DC8", VA = "0x1C79DC8")]
	public void Init(uint skinid)
	{
	}

	[Token(Token = "0x6003C13")]
	[Address(RVA = "0x1C79E90", Offset = "0x1C79E90", VA = "0x1C79E90")]
	public List<PetAnimation> BindAnimation()
	{
		return null;
	}

	[Token(Token = "0x6003C14")]
	[Address(RVA = "0x1C7A450", Offset = "0x1C7A450", VA = "0x1C7A450")]
	private void SetAnimtionSpeed(string name, float scale)
	{
	}

	[Token(Token = "0x6003C15")]
	[Address(RVA = "0x1C7A4E0", Offset = "0x1C7A4E0", VA = "0x1C7A4E0")]
	public void SetAnimtionEnable(bool enable)
	{
	}

	[Token(Token = "0x6003C16")]
	[Address(RVA = "0x1C7A514", Offset = "0x1C7A514", VA = "0x1C7A514", Slot = "6")]
	public GameObject GameObject()
	{
		return null;
	}

	[Token(Token = "0x6003C17")]
	[Address(RVA = "0x1C7A51C", Offset = "0x1C7A51C", VA = "0x1C7A51C", Slot = "4")]
	public void OnEnterTransform()
	{
	}

	[Token(Token = "0x6003C18")]
	[Address(RVA = "0x1C7A554", Offset = "0x1C7A554", VA = "0x1C7A554", Slot = "5")]
	public void OnExitTransform()
	{
	}

	[Token(Token = "0x6003C19")]
	[Address(RVA = "0x1C7A58C", Offset = "0x1C7A58C", VA = "0x1C7A58C", Slot = "7")]
	public void SetColliderEnable(bool isEnable, int layerMask)
	{
	}

	[Token(Token = "0x6003C1A")]
	[Address(RVA = "0x1C7A590", Offset = "0x1C7A590", VA = "0x1C7A590", Slot = "8")]
	public Transform GetBoneByName(string boneName)
	{
		return null;
	}

	[Token(Token = "0x6003C1B")]
	[Address(RVA = "0x1C7A770", Offset = "0x1C7A770", VA = "0x1C7A770", Slot = "9")]
	public bool IsUseTransformCameraBackOffset()
	{
		return default(bool);
	}

	[Token(Token = "0x6003C1C")]
	[Address(RVA = "0x1C7A778", Offset = "0x1C7A778", VA = "0x1C7A778", Slot = "10")]
	public void SetUseTransformCameraBackOffset(bool isUse)
	{
	}

	[Token(Token = "0x6003C1D")]
	[Address(RVA = "0x1C7A77C", Offset = "0x1C7A77C", VA = "0x1C7A77C", Slot = "11")]
	public void PlayAnim(string animName, float speed = 1f)
	{
	}

	[Token(Token = "0x6003C1E")]
	[Address(RVA = "0x1C7A878", Offset = "0x1C7A878", VA = "0x1C7A878", Slot = "12")]
	public void PlayAnim(ODFIIFHKNNG petAction)
	{
	}

	[Token(Token = "0x6003C1F")]
	[Address(RVA = "0x1C7A9EC", Offset = "0x1C7A9EC", VA = "0x1C7A9EC")]
	public void SetVisible(bool isVisible)
	{
	}
}
