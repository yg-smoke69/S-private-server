using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x200042E")]
internal class OpeningCamera : CameraControllerBase
{
	[Token(Token = "0x200042F")]
	private enum NCOIOKDCMFO
	{
		[Token(Token = "0x4003B9F")]
		EOpeningPhase_None,
		[Token(Token = "0x4003BA0")]
		EOpeningPhase_Enter,
		[Token(Token = "0x4003BA1")]
		EOpeningPhase_Far,
		[Token(Token = "0x4003BA2")]
		EOpeningPhase_Approach,
		[Token(Token = "0x4003BA3")]
		EOpeningPhase_Transition,
		[Token(Token = "0x4003BA4")]
		EOpeningPhse_End
	}

	[Token(Token = "0x4003B81")]
	[FieldOffset(Offset = "0x24")]
	public float Phase1CameraUpOffset;

	[Token(Token = "0x4003B82")]
	[FieldOffset(Offset = "0x28")]
	public float Phase1CameraBackOffset;

	[Token(Token = "0x4003B83")]
	[FieldOffset(Offset = "0x2C")]
	public float Phase1CameraRightOffset;

	[Token(Token = "0x4003B84")]
	[FieldOffset(Offset = "0x30")]
	public float Phase1CameraEulerAnglesX;

	[Token(Token = "0x4003B85")]
	[FieldOffset(Offset = "0x34")]
	public float Phase1CameraEulerAnglesY;

	[Token(Token = "0x4003B86")]
	[FieldOffset(Offset = "0x38")]
	public float Phase1Duration;

	[Token(Token = "0x4003B87")]
	[FieldOffset(Offset = "0x3C")]
	public float Phase2Duration;

	[Token(Token = "0x4003B88")]
	[FieldOffset(Offset = "0x40")]
	public float Phase3Duration;

	[Token(Token = "0x4003B89")]
	[FieldOffset(Offset = "0x44")]
	public float Phase2CameraUpOffset;

	[Token(Token = "0x4003B8A")]
	[FieldOffset(Offset = "0x48")]
	public float Phase2CameraBackOffset;

	[Token(Token = "0x4003B8B")]
	[FieldOffset(Offset = "0x4C")]
	public float Phase2CameraRightOffset;

	[Token(Token = "0x4003B8C")]
	[FieldOffset(Offset = "0x50")]
	public float Phase2CameraEulerAnglesX;

	[Token(Token = "0x4003B8D")]
	[FieldOffset(Offset = "0x54")]
	public float Phase2CameraEulerAnglesY;

	[Token(Token = "0x4003B8E")]
	[FieldOffset(Offset = "0x58")]
	public float Phase3CameraUpOffset;

	[Token(Token = "0x4003B8F")]
	[FieldOffset(Offset = "0x5C")]
	public float Phase3CameraBackOffset;

	[Token(Token = "0x4003B90")]
	[FieldOffset(Offset = "0x60")]
	public float Phase3CameraEulerAnglesX;

	[Token(Token = "0x4003B91")]
	[FieldOffset(Offset = "0x64")]
	public float Phase3CameraEulerAnglesY;

	[Token(Token = "0x4003B92")]
	[FieldOffset(Offset = "0x68")]
	private float KPDOBABJPFJ;

	[Token(Token = "0x4003B93")]
	[FieldOffset(Offset = "0x6C")]
	private float OPOIPBFJIMK;

	[Token(Token = "0x4003B94")]
	[FieldOffset(Offset = "0x70")]
	private float CPOPGHIFLDD;

	[Token(Token = "0x4003B95")]
	[FieldOffset(Offset = "0x74")]
	private float AOLFIKJPKED;

	[Token(Token = "0x4003B96")]
	[FieldOffset(Offset = "0x78")]
	private float MNDAKBHPFBB;

	[Token(Token = "0x4003B97")]
	[FieldOffset(Offset = "0x7C")]
	private float MBHNJLJGLPO;

	[Token(Token = "0x4003B98")]
	[FieldOffset(Offset = "0x80")]
	public float TransSpeed;

	[Token(Token = "0x4003B99")]
	[FieldOffset(Offset = "0x84")]
	private NCOIOKDCMFO KBOEILABHCM;

	[Token(Token = "0x4003B9A")]
	[FieldOffset(Offset = "0x88")]
	private float JGEFFDIBBCM;

	[Token(Token = "0x4003B9B")]
	[FieldOffset(Offset = "0x8C")]
	private float FELPNLPOEDC;

	[Token(Token = "0x4003B9C")]
	[FieldOffset(Offset = "0x90")]
	private float NPCAPJOEPEN;

	[Token(Token = "0x4003B9D")]
	[FieldOffset(Offset = "0x94")]
	private float MIBIODPLJBE;

	[Token(Token = "0x60014C0")]
	[Address(RVA = "0x1645688", Offset = "0x1645688", VA = "0x1645688")]
	public OpeningCamera()
	{
	}

	[Token(Token = "0x60014C1")]
	[Address(RVA = "0x1645720", Offset = "0x1645720", VA = "0x1645720", Slot = "6")]
	public override void OnCameraChanged()
	{
	}

	[Token(Token = "0x60014C2")]
	[Address(RVA = "0x164588C", Offset = "0x164588C", VA = "0x164588C")]
	public void SetOffset(bool MKLKBFHMNBD = false)
	{
	}

	[Token(Token = "0x60014C3")]
	[Address(RVA = "0x1645964", Offset = "0x1645964", VA = "0x1645964")]
	protected void GAPPNBOBABL()
	{
	}

	[Token(Token = "0x60014C4")]
	[Address(RVA = "0x1645AF0", Offset = "0x1645AF0", VA = "0x1645AF0")]
	protected void FixedUpdate()
	{
	}

	[Token(Token = "0x60014C5")]
	[Address(RVA = "0x1645DCC", Offset = "0x1645DCC", VA = "0x1645DCC")]
	public void _003C_003EiFixBaseProxy_OnCameraChanged()
	{
	}
}
