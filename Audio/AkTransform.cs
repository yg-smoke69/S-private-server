using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003DAB")]
public class AkTransform : _Attribute
{
	[Token(Token = "0x401A364")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A365")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x60191CA")]
	[Address(RVA = "0x2EBB4B4", Offset = "0x2EBB4B4", VA = "0x2EBB4B4")]
	internal AkTransform(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x60191CB")]
	[Address(RVA = "0x2EBB4DC", Offset = "0x2EBB4DC", VA = "0x2EBB4DC")]
	public AkTransform()
	{
	}

	[Token(Token = "0x60191CC")]
	[Address(RVA = "0x2EBB578", Offset = "0x2EBB578", VA = "0x2EBB578")]
	internal static IntPtr getCPtr(AkTransform obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60191CD")]
	[Address(RVA = "0x2EBB5D0", Offset = "0x2EBB5D0", VA = "0x2EBB5D0", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60191CE")]
	[Address(RVA = "0x2EBB5FC", Offset = "0x2EBB5FC", VA = "0x2EBB5FC", Slot = "1")]
	~AkTransform()
	{
	}

	[Token(Token = "0x60191CF")]
	[Address(RVA = "0x2EBB670", Offset = "0x2EBB670", VA = "0x2EBB670", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x60191D0")]
	[Address(RVA = "0x2EBB79C", Offset = "0x2EBB79C", VA = "0x2EBB79C")]
	public AkVector Position()
	{
		return null;
	}

	[Token(Token = "0x60191D1")]
	[Address(RVA = "0x2EBB880", Offset = "0x2EBB880", VA = "0x2EBB880")]
	public AkVector OrientationFront()
	{
		return null;
	}

	[Token(Token = "0x60191D2")]
	[Address(RVA = "0x2EBB93C", Offset = "0x2EBB93C", VA = "0x2EBB93C")]
	public AkVector OrientationTop()
	{
		return null;
	}

	[Token(Token = "0x60191D3")]
	[Address(RVA = "0x2EBB9F8", Offset = "0x2EBB9F8", VA = "0x2EBB9F8")]
	public void Set(AkVector in_position, AkVector in_orientationFront, AkVector in_orientationTop)
	{
	}

	[Token(Token = "0x60191D4")]
	[Address(RVA = "0x2EBBB5C", Offset = "0x2EBBB5C", VA = "0x2EBBB5C")]
	public void Set(float in_positionX, float in_positionY, float in_positionZ, float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ)
	{
	}

	[Token(Token = "0x60191D5")]
	[Address(RVA = "0x2EBBC40", Offset = "0x2EBBC40", VA = "0x2EBBC40")]
	public void SetPosition(AkVector in_position)
	{
	}

	[Token(Token = "0x60191D6")]
	[Address(RVA = "0x2EBBD18", Offset = "0x2EBBD18", VA = "0x2EBBD18")]
	public void SetPosition(float in_x, float in_y, float in_z)
	{
	}

	[Token(Token = "0x60191D7")]
	[Address(RVA = "0x2EBBDC4", Offset = "0x2EBBDC4", VA = "0x2EBBDC4")]
	public void SetOrientation(AkVector in_orientationFront, AkVector in_orientationTop)
	{
	}

	[Token(Token = "0x60191D8")]
	[Address(RVA = "0x2EBBEB0", Offset = "0x2EBBEB0", VA = "0x2EBBEB0")]
	public void SetOrientation(float in_orientFrontX, float in_orientFrontY, float in_orientFrontZ, float in_orientTopX, float in_orientTopY, float in_orientTopZ)
	{
	}
}
