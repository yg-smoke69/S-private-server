using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000A19")]
internal class ActionSkillPawn : ReusableObject, _Attribute, IConvertible
{
	[Token(Token = "0x4005ADF")]
	[FieldOffset(Offset = "0x18")]
	private Player LKJJENMMLCN;

	[Token(Token = "0x4005AE0")]
	[FieldOffset(Offset = "0x1C")]
	private ActSkillManager LFGIFIFFLAA;

	[Token(Token = "0x4005AE1")]
	[FieldOffset(Offset = "0x20")]
	private SimpleAnimationSystemComponent EDCEFDKNGFJ;

	[Token(Token = "0x4005AE2")]
	[FieldOffset(Offset = "0x24")]
	private HitDetectColliderHelper[] ILFLBBLHEKO;

	[Token(Token = "0x4005AE3")]
	[FieldOffset(Offset = "0x28")]
	private bool _003CBPGLHOEKKFB_003Ek__BackingField;

	[Token(Token = "0x4005AE4")]
	[FieldOffset(Offset = "0x2C")]
	private AnimationID COMCJEDMCEO;

	[Token(Token = "0x4005AE5")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, Transform> MILLMPIFAIA;

	[Token(Token = "0x17000625")]
	public Player DFPPFJAPINP
	{
		[Token(Token = "0x6004ED7")]
		[Address(RVA = "0x1134268", Offset = "0x1134268", VA = "0x1134268")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000626")]
	public bool HJDKDOKAJAI
	{
		[Token(Token = "0x6004ED8")]
		[Address(RVA = "0x11342C0", Offset = "0x11342C0", VA = "0x11342C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000627")]
	public bool EOBMPELNOMC
	{
		[Token(Token = "0x6004ED9")]
		[Address(RVA = "0x11343BC", Offset = "0x11343BC", VA = "0x11343BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000628")]
	private bool ANAFNLLHANG
	{
		[Token(Token = "0x6004EDB")]
		[Address(RVA = "0x1134498", Offset = "0x1134498", VA = "0x1134498")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004EDA")]
		[Address(RVA = "0x1134490", Offset = "0x1134490", VA = "0x1134490")]
		set
		{
		}
	}

	[Token(Token = "0x6004ED6")]
	[Address(RVA = "0x11341C8", Offset = "0x11341C8", VA = "0x11341C8")]
	public ActionSkillPawn()
	{
	}

	[Token(Token = "0x6004EDC")]
	[Address(RVA = "0x11344A0", Offset = "0x11344A0", VA = "0x11344A0", Slot = "11")]
	public bool IsUseTransformCameraBackOffset()
	{
		return default(bool);
	}

	[Token(Token = "0x6004EDD")]
	[Address(RVA = "0x11344F8", Offset = "0x11344F8", VA = "0x11344F8", Slot = "12")]
	public void SetUseTransformCameraBackOffset(bool FGODFHOKEAP)
	{
	}

	[Token(Token = "0x6004EDE")]
	[Address(RVA = "0x1134558", Offset = "0x1134558", VA = "0x1134558", Slot = "14")]
	public void RegisterPlayer(Player BNDGMFKDCII, GameObject GDOGIGDHJJO)
	{
	}

	[Token(Token = "0x6004EDF")]
	[Address(RVA = "0x1134AF4", Offset = "0x1134AF4", VA = "0x1134AF4", Slot = "15")]
	public void UnregisterPlayer()
	{
	}

	[Token(Token = "0x6004EE0")]
	[Address(RVA = "0x1134B80", Offset = "0x1134B80", VA = "0x1134B80", Slot = "16")]
	public Player GetPlayer()
	{
		return null;
	}

	[Token(Token = "0x6004EE1")]
	[Address(RVA = "0x1134918", Offset = "0x1134918", VA = "0x1134918")]
	public void SetSkillActive(bool EBMEPDAJPEM)
	{
	}

	[Token(Token = "0x6004EE2")]
	[Address(RVA = "0x1134BD8", Offset = "0x1134BD8", VA = "0x1134BD8", Slot = "13")]
	public GameObject GameObject()
	{
		return null;
	}

	[Token(Token = "0x6004EE3")]
	[Address(RVA = "0x1134C3C", Offset = "0x1134C3C", VA = "0x1134C3C", Slot = "6")]
	public void OnEnterTransform()
	{
	}

	[Token(Token = "0x6004EE4")]
	[Address(RVA = "0x1134CC4", Offset = "0x1134CC4", VA = "0x1134CC4", Slot = "7")]
	public void OnExitTransform()
	{
	}

	[Token(Token = "0x6004EE5")]
	[Address(RVA = "0x1134D5C", Offset = "0x1134D5C", VA = "0x1134D5C", Slot = "23")]
	public bool IsRunningSkill()
	{
		return default(bool);
	}

	[Token(Token = "0x6004EE6")]
	[Address(RVA = "0x1134DBC", Offset = "0x1134DBC", VA = "0x1134DBC", Slot = "24")]
	public bool CheckSkillCanCast(int HHLONFLCJBL)
	{
		return default(bool);
	}

	[Token(Token = "0x6004EE7")]
	[Address(RVA = "0x1134EC8", Offset = "0x1134EC8", VA = "0x1134EC8", Slot = "17")]
	public void UpdateSkill(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004EE8")]
	[Address(RVA = "0x11350F8", Offset = "0x11350F8", VA = "0x11350F8", Slot = "19")]
	public void TryToCastActSkillByIndex(int HHLONFLCJBL, bool IMGAECDPPCF = false)
	{
	}

	[Token(Token = "0x6004EE9")]
	[Address(RVA = "0x1135194", Offset = "0x1135194", VA = "0x1135194", Slot = "20")]
	public void PlaySkillPhaseAnim(string FIHEJIKOFMM)
	{
	}

	[Token(Token = "0x6004EEA")]
	[Address(RVA = "0x1135340", Offset = "0x1135340", VA = "0x1135340", Slot = "18")]
	public void OnActSkillFinished(KBJIDDDPPOO GEPIPPKAIBK)
	{
	}

	[Token(Token = "0x6004EEB")]
	[Address(RVA = "0x1135214", Offset = "0x1135214", VA = "0x1135214")]
	public void PlayAnimByName(string JGGAMEHMIAH, float IPIAFHGNKNJ = 0f, bool MPFFKJKDEEI = false)
	{
	}

	[Token(Token = "0x6004EEC")]
	[Address(RVA = "0x1135468", Offset = "0x1135468", VA = "0x1135468")]
	public void PlayAnimByID(AnimationID MFNEABEJJCB, float IPIAFHGNKNJ = 0f, bool MPFFKJKDEEI = false)
	{
	}

	[Token(Token = "0x6004EED")]
	[Address(RVA = "0x1134F80", Offset = "0x1134F80", VA = "0x1134F80")]
	public void UpdatePhysxAnim()
	{
	}

	[Token(Token = "0x6004EEE")]
	[Address(RVA = "0x113568C", Offset = "0x113568C", VA = "0x113568C")]
	private bool JIMIGOEMINP(AnimationID HAFLAHPJIFO)
	{
		return default(bool);
	}

	[Token(Token = "0x6004EEF")]
	[Address(RVA = "0x11359D0", Offset = "0x11359D0", VA = "0x11359D0", Slot = "21")]
	public void OnPlayerPlayAnim(AnimationID OKECEIPHOBM)
	{
	}

	[Token(Token = "0x6004EF0")]
	[Address(RVA = "0x11353D8", Offset = "0x11353D8", VA = "0x11353D8")]
	public void SyncPlayPlayerAnim(AnimationID OKECEIPHOBM)
	{
	}

	[Token(Token = "0x6004EF1")]
	[Address(RVA = "0x1134998", Offset = "0x1134998", VA = "0x1134998")]
	private void LLIPGNOGKPP()
	{
	}

	[Token(Token = "0x6004EF2")]
	[Address(RVA = "0x1135AEC", Offset = "0x1135AEC", VA = "0x1135AEC", Slot = "22")]
	public void SetColliderEnable(bool MCDIDHODHLN, int NFIFPONEOID)
	{
	}

	[Token(Token = "0x6004EF3")]
	[Address(RVA = "0x1135B5C", Offset = "0x1135B5C", VA = "0x1135B5C", Slot = "10")]
	public Transform GetBoneByName(string IBGJHGFMNBM)
	{
		return null;
	}
}
