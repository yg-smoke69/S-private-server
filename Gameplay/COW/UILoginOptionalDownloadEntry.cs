using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003365")]
public class UILoginOptionalDownloadEntry : MonoBehaviour
{
	[Token(Token = "0x4013933")]
	[FieldOffset(Offset = "0xC")]
	public UILabel DownloadTips;

	[Token(Token = "0x4013934")]
	[FieldOffset(Offset = "0x10")]
	public GameObject IntroTips;

	[Token(Token = "0x4013935")]
	[FieldOffset(Offset = "0x14")]
	public UISprite RuningSprite;

	[Token(Token = "0x4013936")]
	private const float CIRCLE_SPEED = 0.2f;

	[Token(Token = "0x4013937")]
	[FieldOffset(Offset = "0x18")]
	private UIModelOptionalDownload m_ModelOptionalDownload;

	[Token(Token = "0x4013938")]
	[FieldOffset(Offset = "0x1C")]
	private EModelDownloadState m_DownloadState;

	[Token(Token = "0x6015DC8")]
	[Address(RVA = "0x21F4D54", Offset = "0x21F4D54", VA = "0x21F4D54")]
	public UILoginOptionalDownloadEntry()
	{
	}

	[Token(Token = "0x6015DC9")]
	[Address(RVA = "0x21F4D5C", Offset = "0x21F4D5C", VA = "0x21F4D5C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6015DCA")]
	[Address(RVA = "0x21F4E3C", Offset = "0x21F4E3C", VA = "0x21F4E3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6015DCB")]
	[Address(RVA = "0x21F4F40", Offset = "0x21F4F40", VA = "0x21F4F40")]
	private void Update()
	{
	}
}
