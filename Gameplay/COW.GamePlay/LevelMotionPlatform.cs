using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000660")]
public class LevelMotionPlatform : LevelMovePlatform
{
	[Token(Token = "0x2000661")]
	protected enum IGLEGGIJFFL
	{
		[Token(Token = "0x4004794")]
		None,
		[Token(Token = "0x4004795")]
		Stable,
		[Token(Token = "0x4004796")]
		Moving
	}

	[Token(Token = "0x2000662")]
	public enum KHKKPACHHGE
	{
		[Token(Token = "0x4004798")]
		Position,
		[Token(Token = "0x4004799")]
		Rotation,
		[Token(Token = "0x400479A")]
		Scale
	}

	[Token(Token = "0x4004786")]
	[FieldOffset(Offset = "0x90")]
	public KHKKPACHHGE m_MotionType;

	[Token(Token = "0x4004787")]
	[FieldOffset(Offset = "0x94")]
	public Vector3 m_StartValue;

	[Token(Token = "0x4004788")]
	[FieldOffset(Offset = "0xA0")]
	public Vector3 m_EndValue;

	[Token(Token = "0x4004789")]
	[FieldOffset(Offset = "0xAC")]
	public float m_StartMoment;

	[Token(Token = "0x400478A")]
	[FieldOffset(Offset = "0xB0")]
	public float m_MotionTime;

	[Token(Token = "0x400478B")]
	[FieldOffset(Offset = "0xB4")]
	public float m_StayTime;

	[Token(Token = "0x400478C")]
	[FieldOffset(Offset = "0xB8")]
	public bool m_IsReset;

	[Token(Token = "0x400478D")]
	[FieldOffset(Offset = "0xB9")]
	protected bool IDGDLLJCNBN;

	[Token(Token = "0x400478E")]
	[FieldOffset(Offset = "0xBC")]
	protected float DKOODPIOLLD;

	[Token(Token = "0x400478F")]
	[FieldOffset(Offset = "0xC0")]
	public bool DontNeedTick;

	[Token(Token = "0x4004790")]
	[FieldOffset(Offset = "0xC4")]
	private Quaternion BPLOAFBIHJL;

	[Token(Token = "0x4004791")]
	[FieldOffset(Offset = "0xD4")]
	protected IGLEGGIJFFL ILGECLEFCCO;

	[Token(Token = "0x4004792")]
	[FieldOffset(Offset = "0xD8")]
	protected bool OHIPGHDPDEG;

	[Token(Token = "0x600280E")]
	[Address(RVA = "0x24C7F60", Offset = "0x24C7F60", VA = "0x24C7F60")]
	public LevelMotionPlatform()
	{
	}

	[Token(Token = "0x600280F")]
	[Address(RVA = "0x24C8044", Offset = "0x24C8044", VA = "0x24C8044", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002810")]
	[Address(RVA = "0x24C80E8", Offset = "0x24C80E8", VA = "0x24C80E8")]
	public uint GetPlatformId()
	{
		return default(uint);
	}

	[Token(Token = "0x6002811")]
	[Address(RVA = "0x24C81F8", Offset = "0x24C81F8", VA = "0x24C81F8", Slot = "40")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6002812")]
	[Address(RVA = "0x24C8264", Offset = "0x24C8264", VA = "0x24C8264", Slot = "41")]
	protected virtual void OLKDBDEIJMK()
	{
	}

	[Token(Token = "0x6002813")]
	[Address(RVA = "0x24C8468", Offset = "0x24C8468", VA = "0x24C8468")]
	public void RegisterPlatformIfNeed()
	{
	}

	[Token(Token = "0x6002814")]
	[Address(RVA = "0x24C8588", Offset = "0x24C8588", VA = "0x24C8588")]
	private void OnApplicationPause(bool IEHLJGPHGLM)
	{
	}

	[Token(Token = "0x6002815")]
	[Address(RVA = "0x24C85EC", Offset = "0x24C85EC", VA = "0x24C85EC", Slot = "42")]
	public virtual float GetCurFrameTime()
	{
		return default(float);
	}

	[Token(Token = "0x6002816")]
	[Address(RVA = "0x24C864C", Offset = "0x24C864C", VA = "0x24C864C")]
	public bool CheckServerTickInitState(float EAHHJDBOCLH)
	{
		return default(bool);
	}

	[Token(Token = "0x6002817")]
	[Address(RVA = "0x24C882C", Offset = "0x24C882C", VA = "0x24C882C", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002818")]
	[Address(RVA = "0x24C88FC", Offset = "0x24C88FC", VA = "0x24C88FC")]
	protected bool OCGNNNJDHCB(float EAHHJDBOCLH, out Vector3 NHHKMOFMLIO)
	{
		return default(bool);
	}

	[Token(Token = "0x6002819")]
	[Address(RVA = "0x24C8DE4", Offset = "0x24C8DE4", VA = "0x24C8DE4")]
	protected void JKHPHOAGNKJ(Vector3 NHHKMOFMLIO)
	{
	}

	[Token(Token = "0x600281A")]
	[Address(RVA = "0x24C8F34", Offset = "0x24C8F34", VA = "0x24C8F34")]
	public void SetMotionData(KHKKPACHHGE CNFAJABDECD, Vector3 MNLCLDPGOIF, Vector3 GBLHNEEIHKG, float MPONAHDHALP)
	{
	}

	[Token(Token = "0x600281B")]
	[Address(RVA = "0x24C9148", Offset = "0x24C9148", VA = "0x24C9148")]
	public void UpdateMotionValue()
	{
	}

	[Token(Token = "0x600281C")]
	[Address(RVA = "0x24C95F8", Offset = "0x24C95F8", VA = "0x24C95F8")]
	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x600281D")]
	[Address(RVA = "0x24C96A0", Offset = "0x24C96A0", VA = "0x24C96A0")]
	public new void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
