using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x20006D4")]
public class LevelUAVDrop : BaseLevelObject
{
	[Token(Token = "0x20006D5")]
	public enum IEODLBPDFGE
	{
		[Token(Token = "0x4004AFA")]
		SYNC_STATE,
		[Token(Token = "0x4004AFB")]
		DESTROY
	}

	[Token(Token = "0x20006D6")]
	private class HHCBNAPCKHF : ShadowStateBase
	{
		[Token(Token = "0x4004AFC")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 PGDEDHFOMCN;

		[Token(Token = "0x4004AFD")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion BPLOAFBIHJL;

		[Token(Token = "0x4004AFE")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 JHJLNLCEGOG;

		[Token(Token = "0x4004AFF")]
		[FieldOffset(Offset = "0x38")]
		public Quaternion FBMPKHMBHAM;

		[Token(Token = "0x4004B00")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 LMNBBBCKMGB;

		[Token(Token = "0x6002BAF")]
		[Address(RVA = "0x242F114", Offset = "0x242F114", VA = "0x242F114")]
		public HHCBNAPCKHF()
		{
		}
	}

	[Token(Token = "0x4004AF3")]
	[FieldOffset(Offset = "0x74")]
	protected uint KINJCKMOGIM;

	[Token(Token = "0x4004AF4")]
	[FieldOffset(Offset = "0x78")]
	protected Vector3 LPJGJCMGKPI;

	[Token(Token = "0x4004AF5")]
	[FieldOffset(Offset = "0x84")]
	protected Vector3 FGBDMMJEHBB;

	[Token(Token = "0x4004AF6")]
	[FieldOffset(Offset = "0x90")]
	private HHCBNAPCKHF PLGAAJABBHA;

	[Token(Token = "0x4004AF7")]
	[FieldOffset(Offset = "0x94")]
	private Queue<Vector3> FHGEKDFLHCJ;

	[Token(Token = "0x4004AF8")]
	[FieldOffset(Offset = "0x98")]
	private Vector3 PAFCJPKBBNO;

	[Token(Token = "0x6002BA6")]
	[Address(RVA = "0x242EFE0", Offset = "0x242EFE0", VA = "0x242EFE0")]
	public LevelUAVDrop()
	{
	}

	[Token(Token = "0x6002BA7")]
	[Address(RVA = "0x242F11C", Offset = "0x242F11C", VA = "0x242F11C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002BA8")]
	[Address(RVA = "0x242F1C0", Offset = "0x242F1C0", VA = "0x242F1C0", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6002BA9")]
	[Address(RVA = "0x242F46C", Offset = "0x242F46C", VA = "0x242F46C", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002BAA")]
	[Address(RVA = "0x242F7DC", Offset = "0x242F7DC", VA = "0x242F7DC")]
	private void ADJHJOCPFNJ(DNIMPFCEEGA HKAABMDNNAG, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6002BAB")]
	[Address(RVA = "0x242FC20", Offset = "0x242FC20", VA = "0x242FC20", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002BAC")]
	[Address(RVA = "0x24301B8", Offset = "0x24301B8", VA = "0x24301B8")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x6002BAD")]
	[Address(RVA = "0x24301C0", Offset = "0x24301C0", VA = "0x24301C0")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6002BAE")]
	[Address(RVA = "0x24301C8", Offset = "0x24301C8", VA = "0x24301C8")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
