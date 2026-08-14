using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000633")]
public class LevelHayrickOrigin : BaseLevelObject
{
	[Token(Token = "0x2000634")]
	public enum JNCMCDACLGC
	{
		[Token(Token = "0x400465D")]
		Add,
		[Token(Token = "0x400465E")]
		Destroy,
		[Token(Token = "0x400465F")]
		Use
	}

	[Token(Token = "0x400465A")]
	[FieldOffset(Offset = "0x74")]
	public Transform m_HayrickEndPos;

	[Token(Token = "0x400465B")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 GPHIHGNKKKB;

	[Token(Token = "0x600266B")]
	[Address(RVA = "0x272B104", Offset = "0x272B104", VA = "0x272B104")]
	public LevelHayrickOrigin()
	{
	}

	[Token(Token = "0x600266C")]
	[Address(RVA = "0x272B10C", Offset = "0x272B10C", VA = "0x272B10C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x600266D")]
	[Address(RVA = "0x272B1B0", Offset = "0x272B1B0", VA = "0x272B1B0", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600266E")]
	[Address(RVA = "0x272B42C", Offset = "0x272B42C", VA = "0x272B42C")]
	public Vector3 GetEndPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600266F")]
	[Address(RVA = "0x272B49C", Offset = "0x272B49C", VA = "0x272B49C", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002670")]
	[Address(RVA = "0x272B50C", Offset = "0x272B50C", VA = "0x272B50C", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002671")]
	[Address(RVA = "0x272B570", Offset = "0x272B570", VA = "0x272B570")]
	public void ShowInMap(string PICNONKEHDF)
	{
	}

	[Token(Token = "0x6002672")]
	[Address(RVA = "0x272B7F0", Offset = "0x272B7F0", VA = "0x272B7F0")]
	public Vector3 CalcPlayerInitVelocity(Vector3 LBHACPPKMGN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002673")]
	[Address(RVA = "0x272BAEC", Offset = "0x272BAEC", VA = "0x272BAEC")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	[Token(Token = "0x6002674")]
	[Address(RVA = "0x272BAF4", Offset = "0x272BAF4", VA = "0x272BAF4")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6002675")]
	[Address(RVA = "0x272BAFC", Offset = "0x272BAFC", VA = "0x272BAFC")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
