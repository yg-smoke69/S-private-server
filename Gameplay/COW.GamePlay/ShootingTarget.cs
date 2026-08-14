using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x2000AF7")]
internal class ShootingTarget : AttackableEntity
{
	[Token(Token = "0x4005F1E")]
	[FieldOffset(Offset = "0x48")]
	private float AKGGDLNLEHB;

	[Token(Token = "0x4005F1F")]
	[FieldOffset(Offset = "0x4C")]
	private bool NFLHBIOCLGF;

	[Token(Token = "0x4005F20")]
	[FieldOffset(Offset = "0x50")]
	private LPHOOEKKHII BOPLAOANKBI;

	[Token(Token = "0x4005F21")]
	[FieldOffset(Offset = "0x54")]
	private ABBFFLLCOAH FOBPFEDOBJL;

	[Token(Token = "0x170006CD")]
	public float LMOOCPALJDD
	{
		[Token(Token = "0x6005470")]
		[Address(RVA = "0x1D72D68", Offset = "0x1D72D68", VA = "0x1D72D68")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170006CE")]
	public bool AOOHOMFNNDO
	{
		[Token(Token = "0x6005471")]
		[Address(RVA = "0x1D72DC0", Offset = "0x1D72DC0", VA = "0x1D72DC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005472")]
		[Address(RVA = "0x1D72E18", Offset = "0x1D72E18", VA = "0x1D72E18")]
		private set
		{
		}
	}

	[Token(Token = "0x170006CF")]
	public LPHOOEKKHII CLCFBJIKGBN
	{
		[Token(Token = "0x6005473")]
		[Address(RVA = "0x1D72E78", Offset = "0x1D72E78", VA = "0x1D72E78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600546F")]
	[Address(RVA = "0x1D72CEC", Offset = "0x1D72CEC", VA = "0x1D72CEC")]
	public ShootingTarget()
	{
	}

	[Token(Token = "0x6005474")]
	[Address(RVA = "0x1D72ED0", Offset = "0x1D72ED0", VA = "0x1D72ED0", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6005475")]
	[Address(RVA = "0x1D72F28", Offset = "0x1D72F28", VA = "0x1D72F28", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6005476")]
	[Address(RVA = "0x1D7309C", Offset = "0x1D7309C", VA = "0x1D7309C", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6005477")]
	[Address(RVA = "0x1D73148", Offset = "0x1D73148", VA = "0x1D73148", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x6005478")]
	[Address(RVA = "0x1D7328C", Offset = "0x1D7328C", VA = "0x1D7328C")]
	public void OnTargetDown()
	{
	}

	[Token(Token = "0x6005479")]
	[Address(RVA = "0x1D73360", Offset = "0x1D73360", VA = "0x1D73360")]
	public void OnTargetReborn()
	{
	}

	[Token(Token = "0x600547A")]
	[Address(RVA = "0x1D73474", Offset = "0x1D73474", VA = "0x1D73474")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x600547B")]
	[Address(RVA = "0x1D7347C", Offset = "0x1D7347C", VA = "0x1D7347C")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x600547C")]
	[Address(RVA = "0x1D73484", Offset = "0x1D73484", VA = "0x1D73484")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}
}
