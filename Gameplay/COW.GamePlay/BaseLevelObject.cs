using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005AB")]
public abstract class BaseLevelObject : COWReplicationEntity
{
	[Token(Token = "0x400436D")]
	[FieldOffset(Offset = "0x40")]
	protected OFJHNKMJNGA CDNKFDBCABL;

	[Token(Token = "0x400436E")]
	[FieldOffset(Offset = "0x44")]
	protected uint EBMHBODBICF;

	[Token(Token = "0x400436F")]
	[FieldOffset(Offset = "0x48")]
	protected string m_UGCEntityID;

	[Token(Token = "0x4004370")]
	[FieldOffset(Offset = "0x4C")]
	protected bool BNAIDEHLNCA;

	[Token(Token = "0x4004371")]
	[FieldOffset(Offset = "0x4D")]
	protected bool FCEBINNKLJL;

	[Token(Token = "0x4004372")]
	[FieldOffset(Offset = "0x50")]
	protected string GCIEFJLANHG;

	[Token(Token = "0x4004373")]
	[FieldOffset(Offset = "0x54")]
	public uint m_PlatformID;

	[Token(Token = "0x4004374")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 m_LocalPositionOnPlatform;

	[Token(Token = "0x4004375")]
	[FieldOffset(Offset = "0x64")]
	public Quaternion m_LocalRotationOnPlatform;

	[Token(Token = "0x170002D6")]
	public OFJHNKMJNGA AKJHECHCKJP
	{
		[Token(Token = "0x600227A")]
		[Address(RVA = "0x13B333C", Offset = "0x13B333C", VA = "0x13B333C")]
		get
		{
			return default(OFJHNKMJNGA);
		}
		[Token(Token = "0x600227B")]
		[Address(RVA = "0x13B341C", Offset = "0x13B341C", VA = "0x13B341C")]
		set
		{
		}
	}

	[Token(Token = "0x170002D7")]
	public uint OGFHJKCOCIK
	{
		[Token(Token = "0x600227C")]
		[Address(RVA = "0x13B347C", Offset = "0x13B347C", VA = "0x13B347C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600227D")]
		[Address(RVA = "0x13B355C", Offset = "0x13B355C", VA = "0x13B355C")]
		set
		{
		}
	}

	[Token(Token = "0x6002279")]
	[Address(RVA = "0x13B2C20", Offset = "0x13B2C20", VA = "0x13B2C20")]
	protected BaseLevelObject()
	{
	}

	[Token(Token = "0x600227E")]
	[Address(RVA = "0x13B35D4", Offset = "0x13B35D4", VA = "0x13B35D4", Slot = "30")]
	public virtual void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600227F")]
	[Address(RVA = "0x13B3630", Offset = "0x13B3630", VA = "0x13B3630", Slot = "31")]
	public virtual void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002280")]
	[Address(RVA = "0x13B301C", Offset = "0x13B301C", VA = "0x13B301C", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002281")]
	[Address(RVA = "0x13B3270", Offset = "0x13B3270", VA = "0x13B3270", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002282")]
	[Address(RVA = "0x13B37C4", Offset = "0x13B37C4", VA = "0x13B37C4")]
	public string GetObjectName()
	{
		return null;
	}

	[Token(Token = "0x6002283")]
	[Address(RVA = "0x13B38E4", Offset = "0x13B38E4", VA = "0x13B38E4")]
	public uint GetObjectID()
	{
		return default(uint);
	}

	[Token(Token = "0x6002284")]
	[Address(RVA = "0x13B39C4", Offset = "0x13B39C4", VA = "0x13B39C4", Slot = "32")]
	protected virtual void CFHFEKAHCAI()
	{
	}

	[Token(Token = "0x6002285")]
	[Address(RVA = "0x13B4250", Offset = "0x13B4250", VA = "0x13B4250", Slot = "33")]
	public virtual void RegisterThis(OFJHNKMJNGA PMGBACFJIHO, uint IDNEFEOPGIF)
	{
	}

	[Token(Token = "0x6002286")]
	[Address(RVA = "0x13B3AE4", Offset = "0x13B3AE4", VA = "0x13B3AE4")]
	private void FLNJFBDLOJN()
	{
	}

	[Token(Token = "0x6002287")]
	[Address(RVA = "0x13B368C", Offset = "0x13B368C", VA = "0x13B368C")]
	public void UnRegisterThis()
	{
	}

	[Token(Token = "0x6002288")]
	[Address(RVA = "0x13B4B58", Offset = "0x13B4B58", VA = "0x13B4B58", Slot = "10")]
	public override void InitEntityInfo()
	{
	}

	[Token(Token = "0x6002289")]
	[Address(RVA = "0x13B4BD4", Offset = "0x13B4BD4", VA = "0x13B4BD4", Slot = "34")]
	public virtual void Hide()
	{
	}

	[Token(Token = "0x600228A")]
	[Address(RVA = "0x13B4C5C", Offset = "0x13B4C5C", VA = "0x13B4C5C", Slot = "35")]
	public virtual void Show(bool EBOJJLIHHCM)
	{
	}

	[Token(Token = "0x600228B")]
	[Address(RVA = "0x13B4CEC", Offset = "0x13B4CEC", VA = "0x13B4CEC", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x600228C")]
	protected abstract string GetObjectTag();

	[Token(Token = "0x600228D")]
	[Address(RVA = "0x13B4D44", Offset = "0x13B4D44", VA = "0x13B4D44", Slot = "37")]
	public virtual void TakeDamage(int JLKLMFHFHFF)
	{
	}

	[Token(Token = "0x600228E")]
	[Address(RVA = "0x13B4DA0", Offset = "0x13B4DA0", VA = "0x13B4DA0", Slot = "38")]
	public virtual void TakeHealing(int EDEOPLNOGPP, IHAAMHPPLMG ONPMGNIIMJD, int OIFJAJJFBLK, [Optional] Vector3 NJMFBKNHMBP, [Optional] Vector3 DOBOBMFMKBJ, [Optional] List<float> NBKBEBFNDBE)
	{
	}

	[Token(Token = "0x600228F")]
	[Address(RVA = "0x13B4E74", Offset = "0x13B4E74", VA = "0x13B4E74", Slot = "39")]
	protected virtual void CHICFJEKCJP()
	{
	}

	[Token(Token = "0x6002290")]
	[Address(RVA = "0x13B4EC8", Offset = "0x13B4EC8", VA = "0x13B4EC8")]
	public void EnterMovePlatformByID(uint KCHKAABMNNI, Vector3 CGIJBBFMKAK, Quaternion OLENAGNHJJA)
	{
	}

	[Token(Token = "0x6002291")]
	[Address(RVA = "0x13B5210", Offset = "0x13B5210", VA = "0x13B5210")]
	public void EnterMovePlatformByID(uint KCHKAABMNNI, Vector3 CGIJBBFMKAK)
	{
	}

	[Token(Token = "0x6002292")]
	[Address(RVA = "0x13B54BC", Offset = "0x13B54BC", VA = "0x13B54BC")]
	public void EnterMovePlatform(LevelMovePlatform DPCPGBELIJE, Vector3 CGIJBBFMKAK, Quaternion OLENAGNHJJA)
	{
	}

	[Token(Token = "0x6002293")]
	[Address(RVA = "0x13B56C4", Offset = "0x13B56C4", VA = "0x13B56C4")]
	public void SetUGCEntityID(string GJGELHKJAKK)
	{
	}

	[Token(Token = "0x6002294")]
	[Address(RVA = "0x13B5724", Offset = "0x13B5724", VA = "0x13B5724")]
	public string GetUGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6002295")]
	[Address(RVA = "0x13B577C", Offset = "0x13B577C", VA = "0x13B577C")]
	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002296")]
	[Address(RVA = "0x13B5784", Offset = "0x13B5784", VA = "0x13B5784")]
	public void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x6002297")]
	[Address(RVA = "0x13B578C", Offset = "0x13B578C", VA = "0x13B578C")]
	public void _003C_003EiFixBaseProxy_InitEntityInfo()
	{
	}
}
