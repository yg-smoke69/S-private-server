using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001FF2")]
public class CarouselAnim : MonoBehaviour
{
	[Token(Token = "0x400C8D5")]
	[FieldOffset(Offset = "0xC")]
	public UIWidget front;

	[Token(Token = "0x400C8D6")]
	[FieldOffset(Offset = "0x10")]
	public UIWidget back;

	[Token(Token = "0x400C8D7")]
	[FieldOffset(Offset = "0x14")]
	public float animDuration;

	[Token(Token = "0x400C8D8")]
	[FieldOffset(Offset = "0x18")]
	public float waitTime;

	[Token(Token = "0x400C8D9")]
	[FieldOffset(Offset = "0x1C")]
	private float deltaTime;

	[Token(Token = "0x400C8DA")]
	[FieldOffset(Offset = "0x20")]
	private int index;

	[Token(Token = "0x400C8DB")]
	[FieldOffset(Offset = "0x24")]
	private TweenAlpha frontAnim;

	[Token(Token = "0x400C8DC")]
	[FieldOffset(Offset = "0x28")]
	private TweenAlpha backAnim;

	[Token(Token = "0x600A12F")]
	[Address(RVA = "0x230CF68", Offset = "0x230CF68", VA = "0x230CF68")]
	public CarouselAnim()
	{
	}

	[Token(Token = "0x600A130")]
	[Address(RVA = "0x230CF70", Offset = "0x230CF70", VA = "0x230CF70")]
	private void Start()
	{
	}

	[Token(Token = "0x600A131")]
	[Address(RVA = "0x230D230", Offset = "0x230D230", VA = "0x230D230")]
	private void Update()
	{
	}

	[Token(Token = "0x600A132")]
	[Address(RVA = "0x230D030", Offset = "0x230D030", VA = "0x230D030")]
	private TweenAlpha InitTween(UIWidget widget, bool front)
	{
		return null;
	}

	[Token(Token = "0x600A133")]
	[Address(RVA = "0x230D3EC", Offset = "0x230D3EC", VA = "0x230D3EC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600A134")]
	[Address(RVA = "0x230D3F0", Offset = "0x230D3F0", VA = "0x230D3F0")]
	private void Reset()
	{
	}
}
