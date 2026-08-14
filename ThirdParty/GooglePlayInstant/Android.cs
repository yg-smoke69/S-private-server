using Il2CppDummyDll;

namespace GooglePlayInstant;

[Token(Token = "0x200007B")]
public static class Android
{
	[Token(Token = "0x4000288")]
	public const string GooglePlayServicesPackageName = "com.google.android.gms";

	[Token(Token = "0x4000289")]
	public const string GooglePlayStorePackageName = "com.android.vending";

	[Token(Token = "0x400028A")]
	public const string ActivityMethodGetIntent = "getIntent";

	[Token(Token = "0x400028B")]
	public const string ActivityMethodStartActivityForResult = "startActivityForResult";

	[Token(Token = "0x400028C")]
	public const string BundleClass = "android.os.Bundle";

	[Token(Token = "0x400028D")]
	public const string BundleMethodGetBoolean = "getBoolean";

	[Token(Token = "0x400028E")]
	public const string BundleMethodGetByteArray = "getByteArray";

	[Token(Token = "0x400028F")]
	public const string BundleMethodGetInt = "getInt";

	[Token(Token = "0x4000290")]
	public const string BundleMethodPutByteArray = "putByteArray";

	[Token(Token = "0x4000291")]
	public const string BundleMethodPutInt = "putInt";

	[Token(Token = "0x4000292")]
	public const string ContentResolverMethodCall = "call";

	[Token(Token = "0x4000293")]
	public const string ContextMethodGetContentResolver = "getContentResolver";

	[Token(Token = "0x4000294")]
	public const string ContextMethodGetPackageManager = "getPackageManager";

	[Token(Token = "0x4000295")]
	public const string IntentActionMain = "android.intent.action.MAIN";

	[Token(Token = "0x4000296")]
	public const string IntentActionView = "android.intent.action.VIEW";

	[Token(Token = "0x4000297")]
	public const string IntentCategoryBrowsable = "android.intent.category.BROWSABLE";

	[Token(Token = "0x4000298")]
	public const string IntentCategoryDefault = "android.intent.category.DEFAULT";

	[Token(Token = "0x4000299")]
	public const string IntentCategoryLauncher = "android.intent.category.LAUNCHER";

	[Token(Token = "0x400029A")]
	public const string IntentClass = "android.content.Intent";

	[Token(Token = "0x400029B")]
	public const string IntentMethodAddCategory = "addCategory";

	[Token(Token = "0x400029C")]
	public const string IntentMethodGetStringExtra = "getStringExtra";

	[Token(Token = "0x400029D")]
	public const string IntentMethodPutExtra = "putExtra";

	[Token(Token = "0x400029E")]
	public const string IntentMethodSetData = "setData";

	[Token(Token = "0x400029F")]
	public const string IntentMethodSetPackage = "setPackage";

	[Token(Token = "0x40002A0")]
	public const string ObjectMethodGetClass = "getClass";

	[Token(Token = "0x40002A1")]
	public const string PackageInfoFieldSignatures = "signatures";

	[Token(Token = "0x40002A2")]
	public const int PackageManagerFieldGetSignatures = 64;

	[Token(Token = "0x40002A3")]
	public const string PackageManagerMethodGetPackageInfo = "getPackageInfo";

	[Token(Token = "0x40002A4")]
	public const string PackageManagerMethodResolveActivity = "resolveActivity";

	[Token(Token = "0x40002A5")]
	public const string PackageManagerMethodResolveContentProvider = "resolveContentProvider";

	[Token(Token = "0x40002A6")]
	public const string ProcessClass = "android.os.Process";

	[Token(Token = "0x40002A7")]
	public const string ProcessMethodMyUid = "myUid";

	[Token(Token = "0x40002A8")]
	public const string ProviderInfoFieldPackageName = "packageName";

	[Token(Token = "0x40002A9")]
	public const string SignatureMethodToByteArray = "toByteArray";

	[Token(Token = "0x40002AA")]
	public const string UriClass = "android.net.Uri";

	[Token(Token = "0x40002AB")]
	public const string UriMethodParse = "parse";

	[Token(Token = "0x40002AC")]
	public const string UriBuilderClass = "android.net.Uri$Builder";

	[Token(Token = "0x40002AD")]
	public const string UriBuilderMethodAppendQueryParameter = "appendQueryParameter";

	[Token(Token = "0x40002AE")]
	public const string UriBuilderMethodAuthority = "authority";

	[Token(Token = "0x40002AF")]
	public const string UriBuilderMethodBuild = "build";

	[Token(Token = "0x40002B0")]
	public const string UriBuilderMethodScheme = "scheme";
}
