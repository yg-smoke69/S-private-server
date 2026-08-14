using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200008A")]
public class AvatarDynamicEffectManager
{
	[Token(Token = "0x40002D5")]
	[FieldOffset(Offset = "0x8")]
	private Entity m_OwnerAvatar;

	[Token(Token = "0x40002D6")]
	[FieldOffset(Offset = "0xC")]
	private DynamicBone m_HairDynamicBone;

	[Token(Token = "0x40002D7")]
	[FieldOffset(Offset = "0x10")]
	private DynamicBone m_HairDynamicBone_L;

	[Token(Token = "0x40002D8")]
	[FieldOffset(Offset = "0x14")]
	private DynamicBone m_HairDynamicBone_R;

	[Token(Token = "0x40002D9")]
	[FieldOffset(Offset = "0x18")]
	private DynamicBone m_TailDBL;

	[Token(Token = "0x40002DA")]
	[FieldOffset(Offset = "0x1C")]
	private DynamicBone m_TailDBR;

	[Token(Token = "0x40002DB")]
	[FieldOffset(Offset = "0x20")]
	private DynamicBone m_ClownHatDB;

	[Token(Token = "0x40002DC")]
	[FieldOffset(Offset = "0x24")]
	private bool m_IsHairDescending;

	[Token(Token = "0x40002DD")]
	[FieldOffset(Offset = "0x28")]
	private ITransformNode m_ChestL;

	[Token(Token = "0x40002DE")]
	[FieldOffset(Offset = "0x2C")]
	private ITransformNode m_TailL;

	[Token(Token = "0x40002DF")]
	[FieldOffset(Offset = "0x30")]
	private ITransformNode m_TailR;

	[Token(Token = "0x40002E0")]
	[FieldOffset(Offset = "0x34")]
	private ITransformNode m_ClownHat;

	[Token(Token = "0x40002E1")]
	[FieldOffset(Offset = "0x38")]
	private ITransformNode m_ChestR;

	[Token(Token = "0x40002E2")]
	[FieldOffset(Offset = "0x3C")]
	private ITransformNode m_HairNode;

	[Token(Token = "0x40002E3")]
	[FieldOffset(Offset = "0x40")]
	private ITransformNode m_HairNode_L;

	[Token(Token = "0x40002E4")]
	[FieldOffset(Offset = "0x44")]
	private ITransformNode m_HairNode_R;

	[Token(Token = "0x17000076")]
	public Entity OwnerAvatar
	{
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x10FCB34", Offset = "0x10FCB34", VA = "0x10FCB34")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x10FCB8C", Offset = "0x10FCB8C", VA = "0x10FCB8C")]
		set
		{
		}
	}

	[Token(Token = "0x17000077")]
	protected Transform ChestL
	{
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x10FCBEC", Offset = "0x10FCBEC", VA = "0x10FCBEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000078")]
	protected Transform TailL
	{
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x10FCE74", Offset = "0x10FCE74", VA = "0x10FCE74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000079")]
	protected Transform TailR
	{
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x10FD0FC", Offset = "0x10FD0FC", VA = "0x10FD0FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007A")]
	protected Transform ClownHat
	{
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x10FD384", Offset = "0x10FD384", VA = "0x10FD384")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007B")]
	protected Transform ChestR
	{
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x10FD60C", Offset = "0x10FD60C", VA = "0x10FD60C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007C")]
	protected Transform HairTransform
	{
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x10FD894", Offset = "0x10FD894", VA = "0x10FD894")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007D")]
	protected Transform HairTransform_L
	{
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x10FDB1C", Offset = "0x10FDB1C", VA = "0x10FDB1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007E")]
	protected Transform HairTransform_R
	{
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x10FDDA4", Offset = "0x10FDDA4", VA = "0x10FDDA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x10FCB2C", Offset = "0x10FCB2C", VA = "0x10FCB2C")]
	public AvatarDynamicEffectManager()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x10FE02C", Offset = "0x10FE02C", VA = "0x10FE02C")]
	private void SetUpChestDynamicBone(DynamicBone dBone)
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x10FE238", Offset = "0x10FE238", VA = "0x10FE238")]
	public void SetUpHairDBStatus(bool isDescending)
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x10FE580", Offset = "0x10FE580", VA = "0x10FE580")]
	public void AddDynamicChest()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x10FE774", Offset = "0x10FE774", VA = "0x10FE774")]
	public void SetupDynamicBoneForIngameMode()
	{
	}
}
