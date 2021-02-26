	.arch	armv8-a
	.file	"typemaps.arm64-v8a.s"

/* map_module_count: START */
	.section	.rodata.map_module_count,"a",@progbits
	.type	map_module_count, @object
	.p2align	2
	.global	map_module_count
map_module_count:
	.size	map_module_count, 4
	.word	3
/* map_module_count: END */

/* java_type_count: START */
	.section	.rodata.java_type_count,"a",@progbits
	.type	java_type_count, @object
	.p2align	2
	.global	java_type_count
java_type_count:
	.size	java_type_count, 4
	.word	315
/* java_type_count: END */

/* java_name_width: START */
	.section	.rodata.java_name_width,"a",@progbits
	.type	java_name_width, @object
	.p2align	2
	.global	java_name_width
java_name_width:
	.size	java_name_width, 4
	.word	91
/* java_name_width: END */

	.include	"typemaps.shared.inc"
	.include	"typemaps.arm64-v8a-managed.inc"

/* Managed to Java map: START */
	.section	.data.rel.map_modules,"aw",@progbits
	.type	map_modules, @object
	.p2align	3
	.global	map_modules
map_modules:
	/* module_uuid: 1b56ae2d-3f84-482f-9fdd-c60699baecb2 */
	.byte	0x2d, 0xae, 0x56, 0x1b, 0x84, 0x3f, 0x2f, 0x48, 0x9f, 0xdd, 0xc6, 0x06, 0x99, 0xba, 0xec, 0xb2
	/* entry_count */
	.word	7
	/* duplicate_count */
	.word	0
	/* map */
	.xword	module0_managed_to_java
	/* duplicate_map */
	.xword	0
	/* assembly_name: SampleFingerprint */
	.xword	.L.map_aname.0
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 7ff2015a-c079-4916-93e1-140ebc6de31c */
	.byte	0x5a, 0x01, 0xf2, 0x7f, 0x79, 0xc0, 0x16, 0x49, 0x93, 0xe1, 0x14, 0x0e, 0xbc, 0x6d, 0xe3, 0x1c
	/* entry_count */
	.word	155
	/* duplicate_count */
	.word	0
	/* map */
	.xword	module1_managed_to_java
	/* duplicate_map */
	.xword	0
	/* assembly_name: CredenceBindings */
	.xword	.L.map_aname.1
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	/* module_uuid: 1daf16ce-8ce6-45b3-a62f-c9913af7cc6f */
	.byte	0xce, 0x16, 0xaf, 0x1d, 0xe6, 0x8c, 0xb3, 0x45, 0xa6, 0x2f, 0xc9, 0x91, 0x3a, 0xf7, 0xcc, 0x6f
	/* entry_count */
	.word	153
	/* duplicate_count */
	.word	24
	/* map */
	.xword	module2_managed_to_java
	/* duplicate_map */
	.xword	module2_managed_to_java_duplicates
	/* assembly_name: Mono.Android */
	.xword	.L.map_aname.2
	/* image */
	.xword	0
	/* java_name_width */
	.word	0
	/* java_map */
	.zero	4
	.xword	0

	.size	map_modules, 216
/* Managed to Java map: END */

/* Java to managed map: START */
	.section	.rodata.map_java,"a",@progbits
	.type	map_java, @object
	.p2align	2
	.global	map_java
map_java:
	/* #0 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554623
	/* java_name */
	.ascii	"android/app/Activity"
	.zero	71

	/* #1 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554624
	/* java_name */
	.ascii	"android/app/Application"
	.zero	68

	/* #2 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554634
	/* java_name */
	.ascii	"android/content/ComponentCallbacks"
	.zero	57

	/* #3 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554636
	/* java_name */
	.ascii	"android/content/ComponentCallbacks2"
	.zero	56

	/* #4 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554630
	/* java_name */
	.ascii	"android/content/ComponentName"
	.zero	62

	/* #5 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554628
	/* java_name */
	.ascii	"android/content/Context"
	.zero	68

	/* #6 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554632
	/* java_name */
	.ascii	"android/content/ContextWrapper"
	.zero	61

	/* #7 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554629
	/* java_name */
	.ascii	"android/content/Intent"
	.zero	69

	/* #8 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554638
	/* java_name */
	.ascii	"android/content/res/Configuration"
	.zero	58

	/* #9 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554610
	/* java_name */
	.ascii	"android/graphics/Bitmap"
	.zero	68

	/* #10 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554611
	/* java_name */
	.ascii	"android/graphics/Canvas"
	.zero	68

	/* #11 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554612
	/* java_name */
	.ascii	"android/graphics/Paint"
	.zero	69

	/* #12 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554613
	/* java_name */
	.ascii	"android/graphics/Paint$Style"
	.zero	63

	/* #13 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554614
	/* java_name */
	.ascii	"android/graphics/Point"
	.zero	69

	/* #14 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554615
	/* java_name */
	.ascii	"android/graphics/PointF"
	.zero	68

	/* #15 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554616
	/* java_name */
	.ascii	"android/graphics/Rect"
	.zero	70

	/* #16 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554617
	/* java_name */
	.ascii	"android/graphics/RectF"
	.zero	69

	/* #17 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554618
	/* java_name */
	.ascii	"android/graphics/drawable/Drawable"
	.zero	57

	/* #18 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554620
	/* java_name */
	.ascii	"android/graphics/drawable/Drawable$Callback"
	.zero	48

	/* #19 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554600
	/* java_name */
	.ascii	"android/os/BaseBundle"
	.zero	70

	/* #20 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554601
	/* java_name */
	.ascii	"android/os/Bundle"
	.zero	74

	/* #21 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554598
	/* java_name */
	.ascii	"android/os/Handler"
	.zero	73

	/* #22 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554606
	/* java_name */
	.ascii	"android/os/Looper"
	.zero	74

	/* #23 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554599
	/* java_name */
	.ascii	"android/os/Message"
	.zero	73

	/* #24 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554607
	/* java_name */
	.ascii	"android/os/Parcel"
	.zero	74

	/* #25 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554605
	/* java_name */
	.ascii	"android/os/Parcelable"
	.zero	70

	/* #26 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554603
	/* java_name */
	.ascii	"android/os/Parcelable$Creator"
	.zero	62

	/* #27 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554684
	/* java_name */
	.ascii	"android/runtime/JavaProxyThrowable"
	.zero	57

	/* #28 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554597
	/* java_name */
	.ascii	"android/util/AttributeSet"
	.zero	66

	/* #29 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554595
	/* java_name */
	.ascii	"android/util/DisplayMetrics"
	.zero	64

	/* #30 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554541
	/* java_name */
	.ascii	"android/view/ActionMode"
	.zero	68

	/* #31 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554543
	/* java_name */
	.ascii	"android/view/ActionMode$Callback"
	.zero	59

	/* #32 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554546
	/* java_name */
	.ascii	"android/view/ActionProvider"
	.zero	64

	/* #33 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554554
	/* java_name */
	.ascii	"android/view/ContextMenu"
	.zero	67

	/* #34 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554552
	/* java_name */
	.ascii	"android/view/ContextMenu$ContextMenuInfo"
	.zero	51

	/* #35 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554548
	/* java_name */
	.ascii	"android/view/ContextThemeWrapper"
	.zero	59

	/* #36 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554549
	/* java_name */
	.ascii	"android/view/Display"
	.zero	71

	/* #37 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554563
	/* java_name */
	.ascii	"android/view/InputEvent"
	.zero	68

	/* #38 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554526
	/* java_name */
	.ascii	"android/view/KeyEvent"
	.zero	70

	/* #39 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554528
	/* java_name */
	.ascii	"android/view/KeyEvent$Callback"
	.zero	61

	/* #40 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554529
	/* java_name */
	.ascii	"android/view/LayoutInflater"
	.zero	64

	/* #41 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554531
	/* java_name */
	.ascii	"android/view/LayoutInflater$Factory"
	.zero	56

	/* #42 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554533
	/* java_name */
	.ascii	"android/view/LayoutInflater$Factory2"
	.zero	55

	/* #43 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554556
	/* java_name */
	.ascii	"android/view/Menu"
	.zero	74

	/* #44 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554562
	/* java_name */
	.ascii	"android/view/MenuItem"
	.zero	70

	/* #45 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554558
	/* java_name */
	.ascii	"android/view/MenuItem$OnActionExpandListener"
	.zero	47

	/* #46 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554560
	/* java_name */
	.ascii	"android/view/MenuItem$OnMenuItemClickListener"
	.zero	46

	/* #47 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554534
	/* java_name */
	.ascii	"android/view/MotionEvent"
	.zero	67

	/* #48 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554580
	/* java_name */
	.ascii	"android/view/SearchEvent"
	.zero	67

	/* #49 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554566
	/* java_name */
	.ascii	"android/view/SubMenu"
	.zero	71

	/* #50 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554518
	/* java_name */
	.ascii	"android/view/View"
	.zero	74

	/* #51 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554520
	/* java_name */
	.ascii	"android/view/View$OnClickListener"
	.zero	58

	/* #52 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554523
	/* java_name */
	.ascii	"android/view/View$OnCreateContextMenuListener"
	.zero	46

	/* #53 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554584
	/* java_name */
	.ascii	"android/view/ViewGroup"
	.zero	69

	/* #54 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554585
	/* java_name */
	.ascii	"android/view/ViewGroup$LayoutParams"
	.zero	56

	/* #55 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554568
	/* java_name */
	.ascii	"android/view/ViewManager"
	.zero	67

	/* #56 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554570
	/* java_name */
	.ascii	"android/view/ViewParent"
	.zero	68

	/* #57 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554535
	/* java_name */
	.ascii	"android/view/ViewTreeObserver"
	.zero	62

	/* #58 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554537
	/* java_name */
	.ascii	"android/view/ViewTreeObserver$OnPreDrawListener"
	.zero	44

	/* #59 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554538
	/* java_name */
	.ascii	"android/view/Window"
	.zero	72

	/* #60 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554540
	/* java_name */
	.ascii	"android/view/Window$Callback"
	.zero	63

	/* #61 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554573
	/* java_name */
	.ascii	"android/view/WindowManager"
	.zero	65

	/* #62 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554571
	/* java_name */
	.ascii	"android/view/WindowManager$LayoutParams"
	.zero	52

	/* #63 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554588
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityEvent"
	.zero	46

	/* #64 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554594
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityEventSource"
	.zero	40

	/* #65 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554589
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityRecord"
	.zero	45

	/* #66 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554514
	/* java_name */
	.ascii	"android/widget/Button"
	.zero	70

	/* #67 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554515
	/* java_name */
	.ascii	"android/widget/ImageView"
	.zero	67

	/* #68 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554513
	/* java_name */
	.ascii	"android/widget/TextView"
	.zero	68

	/* #69 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554516
	/* java_name */
	.ascii	"android/widget/Toast"
	.zero	71

	/* #70 */
	/* module_index */
	.word	0
	/* type_token_id */
	.word	33554435
	/* java_name */
	.ascii	"com/biometricstest/mobile/FingerprintTest/MainActivity"
	.zero	37

	/* #71 */
	/* module_index */
	.word	0
	/* type_token_id */
	.word	33554445
	/* java_name */
	.ascii	"com/biometricstest/mobile/FingerprintTest/MainActivity_BiometricsOnInitializedListener"
	.zero	5

	/* #72 */
	/* module_index */
	.word	0
	/* type_token_id */
	.word	33554450
	/* java_name */
	.ascii	"com/biometricstest/mobile/FingerprintTest/MainActivity_ConvertToFMDListener"
	.zero	16

	/* #73 */
	/* module_index */
	.word	0
	/* type_token_id */
	.word	33554446
	/* java_name */
	.ascii	"com/biometricstest/mobile/FingerprintTest/MainActivity_FingerprintOpenCloseListener"
	.zero	8

	/* #74 */
	/* module_index */
	.word	0
	/* type_token_id */
	.word	33554447
	/* java_name */
	.ascii	"com/biometricstest/mobile/FingerprintTest/MainActivity_GrabFingerOneListener"
	.zero	15

	/* #75 */
	/* module_index */
	.word	0
	/* type_token_id */
	.word	33554448
	/* java_name */
	.ascii	"com/biometricstest/mobile/FingerprintTest/MainActivity_GrabFingerTwoListener"
	.zero	15

	/* #76 */
	/* module_index */
	.word	0
	/* type_token_id */
	.word	33554451
	/* java_name */
	.ascii	"com/biometricstest/mobile/FingerprintTest/MainActivity_OnCompareFmd"
	.zero	24

	/* #77 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554488
	/* java_name */
	.ascii	"com/credenceid/BuildConfig"
	.zero	65

	/* #78 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554489
	/* java_name */
	.ascii	"com/credenceid/CredenceConstants"
	.zero	59

	/* #79 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554567
	/* java_name */
	.ascii	"com/credenceid/biometrics/ApduCommand"
	.zero	54

	/* #80 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554731
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics"
	.zero	55

	/* #81 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554580
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$CardReaderStatusListener"
	.zero	30

	/* #82 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554584
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$CloseReasonCode"
	.zero	39

	/* #83 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554586
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$EPassportReaderStatusListener"
	.zero	25

	/* #84 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554590
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$EyeSelection"
	.zero	42

	/* #85 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554597
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$FMDFormat"
	.zero	45

	/* #86 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554592
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$FingerprintReaderStatusListener"
	.zero	23

	/* #87 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554596
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$FingerprintScannerType"
	.zero	32

	/* #88 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554603
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$GIcaoReadListener"
	.zero	37

	/* #89 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554607
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$GNIDReadListener"
	.zero	38

	/* #90 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554611
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$ICAODocumentReadListener"
	.zero	30

	/* #91 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554615
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$MRZStatusListener"
	.zero	37

	/* #92 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554631
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnCCFToFMDConversionListener"
	.zero	26

	/* #93 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554620
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnCardCommandListener"
	.zero	33

	/* #94 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554624
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnCardCommandSyncResultListener"
	.zero	23

	/* #95 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554627
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnCardStatusListener"
	.zero	34

	/* #96 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554635
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnCompareFMDListener"
	.zero	34

	/* #97 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554639
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnCompressToWSQListener"
	.zero	31

	/* #98 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554643
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnConvertToFMDListener"
	.zero	32

	/* #99 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554647
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnDecompressWSQListener"
	.zero	31

	/* #100 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554655
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnEPassportCommandListener"
	.zero	28

	/* #101 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554659
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnEPassportStatusListener"
	.zero	29

	/* #102 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554651
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnEktpCardReadListener"
	.zero	32

	/* #103 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554687
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnFMDToCCFConversionListener"
	.zero	26

	/* #104 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554683
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnFingerQualityListener"
	.zero	31

	/* #105 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554663
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedFullListener"
	.zero	22

	/* #106 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554668
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedListener"
	.zero	26

	/* #107 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554673
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedRawListener"
	.zero	23

	/* #108 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554678
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedWSQListener"
	.zero	23

	/* #109 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554691
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnGetFingerQualityListener"
	.zero	28

	/* #110 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554695
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnGetProviderDetailsListener"
	.zero	26

	/* #111 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554699
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnInitializedListener"
	.zero	33

	/* #112 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554703
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnIrisesCapturedListener"
	.zero	30

	/* #113 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554712
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnMRZDocumentStatusListener"
	.zero	27

	/* #114 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554716
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnMRZReaderListener"
	.zero	35

	/* #115 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554708
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnMobileDataChangedListener"
	.zero	27

	/* #116 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554720
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$OnMultiFingerprintGrabbedListener"
	.zero	21

	/* #117 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554725
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$PreferencesListener"
	.zero	35

	/* #118 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554728
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$ResultCode"
	.zero	44

	/* #119 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554729
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$ScanType"
	.zero	46

	/* #120 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554599
	/* java_name */
	.ascii	"com/credenceid/biometrics/Biometrics$generateTerminalIsCertificateListener"
	.zero	17

	/* #121 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554568
	/* java_name */
	.ascii	"com/credenceid/biometrics/BiometricsActivity"
	.zero	47

	/* #122 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554569
	/* java_name */
	.ascii	"com/credenceid/biometrics/BiometricsManager"
	.zero	48

	/* #123 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554571
	/* java_name */
	.ascii	"com/credenceid/biometrics/CCFToFMDSyncResponse"
	.zero	45

	/* #124 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554570
	/* java_name */
	.ascii	"com/credenceid/biometrics/CardCommandResponse"
	.zero	46

	/* #125 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554572
	/* java_name */
	.ascii	"com/credenceid/biometrics/CompareFMDSyncResponse"
	.zero	43

	/* #126 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554573
	/* java_name */
	.ascii	"com/credenceid/biometrics/ConvertToFMDSyncResponse"
	.zero	41

	/* #127 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554574
	/* java_name */
	.ascii	"com/credenceid/biometrics/DeviceFamily"
	.zero	53

	/* #128 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554575
	/* java_name */
	.ascii	"com/credenceid/biometrics/DeviceType"
	.zero	55

	/* #129 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554578
	/* java_name */
	.ascii	"com/credenceid/biometrics/FMDToCCFSyncResponse"
	.zero	45

	/* #130 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554577
	/* java_name */
	.ascii	"com/credenceid/biometrics/FingerQuality"
	.zero	52

	/* #131 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554576
	/* java_name */
	.ascii	"com/credenceid/biometrics/FingerprintSyncResponse"
	.zero	42

	/* #132 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554732
	/* java_name */
	.ascii	"com/credenceid/biometrics/IrisQuality"
	.zero	54

	/* #133 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554562
	/* java_name */
	.ascii	"com/credenceid/constants/ServiceConstants"
	.zero	50

	/* #134 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554563
	/* java_name */
	.ascii	"com/credenceid/constants/ServiceConstants$Database"
	.zero	41

	/* #135 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554564
	/* java_name */
	.ascii	"com/credenceid/constants/ServiceConstants$FaceEngine"
	.zero	39

	/* #136 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554565
	/* java_name */
	.ascii	"com/credenceid/constants/ServiceConstants$FingerprintEngine"
	.zero	32

	/* #137 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554566
	/* java_name */
	.ascii	"com/credenceid/constants/ServiceConstants$ICAO"
	.zero	45

	/* #138 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554539
	/* java_name */
	.ascii	"com/credenceid/database/BiometricData"
	.zero	54

	/* #139 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554557
	/* java_name */
	.ascii	"com/credenceid/database/BiometricDatabase"
	.zero	50

	/* #140 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554544
	/* java_name */
	.ascii	"com/credenceid/database/BiometricDatabase$OnDeleteCallback"
	.zero	33

	/* #141 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554546
	/* java_name */
	.ascii	"com/credenceid/database/BiometricDatabase$OnEnrollCallback"
	.zero	33

	/* #142 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554548
	/* java_name */
	.ascii	"com/credenceid/database/BiometricDatabase$OnMatchCallback"
	.zero	34

	/* #143 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554550
	/* java_name */
	.ascii	"com/credenceid/database/BiometricDatabase$OnReadCallback"
	.zero	35

	/* #144 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554552
	/* java_name */
	.ascii	"com/credenceid/database/BiometricDatabase$OnUpdateCallback"
	.zero	33

	/* #145 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554554
	/* java_name */
	.ascii	"com/credenceid/database/BiometricDatabase$OnVerifyCallback"
	.zero	33

	/* #146 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554555
	/* java_name */
	.ascii	"com/credenceid/database/BiometricDatabase$Status"
	.zero	43

	/* #147 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554540
	/* java_name */
	.ascii	"com/credenceid/database/FaceRecord"
	.zero	57

	/* #148 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554541
	/* java_name */
	.ascii	"com/credenceid/database/FingerprintRecord"
	.zero	50

	/* #149 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554542
	/* java_name */
	.ascii	"com/credenceid/database/FingerprintRecord$Position"
	.zero	41

	/* #150 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554558
	/* java_name */
	.ascii	"com/credenceid/database/ImageIndex"
	.zero	57

	/* #151 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554559
	/* java_name */
	.ascii	"com/credenceid/database/IrisRecord"
	.zero	57

	/* #152 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554560
	/* java_name */
	.ascii	"com/credenceid/database/IrisRecord$Position"
	.zero	48

	/* #153 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554561
	/* java_name */
	.ascii	"com/credenceid/database/MatchItem"
	.zero	58

	/* #154 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554513
	/* java_name */
	.ascii	"com/credenceid/face/AnalyzeFaceSyncResponse"
	.zero	48

	/* #155 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554514
	/* java_name */
	.ascii	"com/credenceid/face/CompareFaceSyncResponse"
	.zero	48

	/* #156 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554515
	/* java_name */
	.ascii	"com/credenceid/face/CreateFaceTemplateSyncResponse"
	.zero	41

	/* #157 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554516
	/* java_name */
	.ascii	"com/credenceid/face/DetectFaceSyncResponse"
	.zero	49

	/* #158 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554538
	/* java_name */
	.ascii	"com/credenceid/face/FaceEngine"
	.zero	61

	/* #159 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554518
	/* java_name */
	.ascii	"com/credenceid/face/FaceEngine$Emotion"
	.zero	53

	/* #160 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554519
	/* java_name */
	.ascii	"com/credenceid/face/FaceEngine$Gender"
	.zero	54

	/* #161 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554520
	/* java_name */
	.ascii	"com/credenceid/face/FaceEngine$HeadPoseDirection"
	.zero	43

	/* #162 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554522
	/* java_name */
	.ascii	"com/credenceid/face/FaceEngine$OnAnalyzeFaceImageListener"
	.zero	34

	/* #163 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554526
	/* java_name */
	.ascii	"com/credenceid/face/FaceEngine$OnCreateFaceTemplateListener"
	.zero	32

	/* #164 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554530
	/* java_name */
	.ascii	"com/credenceid/face/FaceEngine$OnDetectFaceListener"
	.zero	40

	/* #165 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554534
	/* java_name */
	.ascii	"com/credenceid/face/FaceEngine$OnMatchFaceTemplatesListener"
	.zero	32

	/* #166 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554517
	/* java_name */
	.ascii	"com/credenceid/face/FaceView"
	.zero	63

	/* #167 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554490
	/* java_name */
	.ascii	"com/credenceid/icao/FingerInfo"
	.zero	61

	/* #168 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554492
	/* java_name */
	.ascii	"com/credenceid/icao/GIdData"
	.zero	64

	/* #169 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554493
	/* java_name */
	.ascii	"com/credenceid/icao/GIdData$DG1"
	.zero	60

	/* #170 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554494
	/* java_name */
	.ascii	"com/credenceid/icao/GIdData$DG10"
	.zero	59

	/* #171 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554495
	/* java_name */
	.ascii	"com/credenceid/icao/GIdData$DG11"
	.zero	59

	/* #172 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554496
	/* java_name */
	.ascii	"com/credenceid/icao/GIdData$DG2"
	.zero	60

	/* #173 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554497
	/* java_name */
	.ascii	"com/credenceid/icao/GIdData$DG3"
	.zero	60

	/* #174 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554498
	/* java_name */
	.ascii	"com/credenceid/icao/GIdData$DG4"
	.zero	60

	/* #175 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554499
	/* java_name */
	.ascii	"com/credenceid/icao/GIdData$DG5"
	.zero	60

	/* #176 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554500
	/* java_name */
	.ascii	"com/credenceid/icao/GIdData$DG6"
	.zero	60

	/* #177 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554501
	/* java_name */
	.ascii	"com/credenceid/icao/GIdData$DG7"
	.zero	60

	/* #178 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554502
	/* java_name */
	.ascii	"com/credenceid/icao/GIdData$DG8"
	.zero	60

	/* #179 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554503
	/* java_name */
	.ascii	"com/credenceid/icao/GIdData$DG9"
	.zero	60

	/* #180 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554491
	/* java_name */
	.ascii	"com/credenceid/icao/GhanaIdCardFpTemplateInfo"
	.zero	46

	/* #181 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554504
	/* java_name */
	.ascii	"com/credenceid/icao/ICAODocumentData"
	.zero	55

	/* #182 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554505
	/* java_name */
	.ascii	"com/credenceid/icao/ICAODocumentData$DG1"
	.zero	51

	/* #183 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554506
	/* java_name */
	.ascii	"com/credenceid/icao/ICAODocumentData$DG11"
	.zero	50

	/* #184 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554507
	/* java_name */
	.ascii	"com/credenceid/icao/ICAODocumentData$DG12"
	.zero	50

	/* #185 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554508
	/* java_name */
	.ascii	"com/credenceid/icao/ICAODocumentData$DG2"
	.zero	51

	/* #186 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554509
	/* java_name */
	.ascii	"com/credenceid/icao/ICAODocumentData$DG3"
	.zero	51

	/* #187 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554510
	/* java_name */
	.ascii	"com/credenceid/icao/ICAODocumentData$DG7"
	.zero	51

	/* #188 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554511
	/* java_name */
	.ascii	"com/credenceid/icao/ICAOReadIntermediateCode"
	.zero	47

	/* #189 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554512
	/* java_name */
	.ascii	"com/credenceid/icao/ICAOUtils"
	.zero	62

	/* #190 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554484
	/* java_name */
	.ascii	"com/util/BitmapUtils"
	.zero	71

	/* #191 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554485
	/* java_name */
	.ascii	"com/util/FileUtils"
	.zero	73

	/* #192 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554486
	/* java_name */
	.ascii	"com/util/HexUtils"
	.zero	74

	/* #193 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554487
	/* java_name */
	.ascii	"com/util/Logger"
	.zero	76

	/* #194 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554803
	/* java_name */
	.ascii	"java/io/Closeable"
	.zero	74

	/* #195 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554801
	/* java_name */
	.ascii	"java/io/FileInputStream"
	.zero	68

	/* #196 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554805
	/* java_name */
	.ascii	"java/io/Flushable"
	.zero	74

	/* #197 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554808
	/* java_name */
	.ascii	"java/io/IOException"
	.zero	72

	/* #198 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554806
	/* java_name */
	.ascii	"java/io/InputStream"
	.zero	72

	/* #199 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554811
	/* java_name */
	.ascii	"java/io/OutputStream"
	.zero	71

	/* #200 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554813
	/* java_name */
	.ascii	"java/io/PrintWriter"
	.zero	72

	/* #201 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554810
	/* java_name */
	.ascii	"java/io/Serializable"
	.zero	71

	/* #202 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554814
	/* java_name */
	.ascii	"java/io/StringWriter"
	.zero	71

	/* #203 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554815
	/* java_name */
	.ascii	"java/io/Writer"
	.zero	77

	/* #204 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554772
	/* java_name */
	.ascii	"java/lang/Appendable"
	.zero	71

	/* #205 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554748
	/* java_name */
	.ascii	"java/lang/Boolean"
	.zero	74

	/* #206 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554749
	/* java_name */
	.ascii	"java/lang/Byte"
	.zero	77

	/* #207 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554773
	/* java_name */
	.ascii	"java/lang/CharSequence"
	.zero	69

	/* #208 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554750
	/* java_name */
	.ascii	"java/lang/Character"
	.zero	72

	/* #209 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554751
	/* java_name */
	.ascii	"java/lang/Class"
	.zero	76

	/* #210 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554767
	/* java_name */
	.ascii	"java/lang/ClassCastException"
	.zero	63

	/* #211 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554752
	/* java_name */
	.ascii	"java/lang/ClassNotFoundException"
	.zero	59

	/* #212 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554776
	/* java_name */
	.ascii	"java/lang/Cloneable"
	.zero	72

	/* #213 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554778
	/* java_name */
	.ascii	"java/lang/Comparable"
	.zero	71

	/* #214 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554753
	/* java_name */
	.ascii	"java/lang/Double"
	.zero	75

	/* #215 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554768
	/* java_name */
	.ascii	"java/lang/Enum"
	.zero	77

	/* #216 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554770
	/* java_name */
	.ascii	"java/lang/Error"
	.zero	76

	/* #217 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554754
	/* java_name */
	.ascii	"java/lang/Exception"
	.zero	72

	/* #218 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554755
	/* java_name */
	.ascii	"java/lang/Float"
	.zero	76

	/* #219 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554779
	/* java_name */
	.ascii	"java/lang/IllegalArgumentException"
	.zero	57

	/* #220 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554780
	/* java_name */
	.ascii	"java/lang/IllegalStateException"
	.zero	60

	/* #221 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554781
	/* java_name */
	.ascii	"java/lang/IndexOutOfBoundsException"
	.zero	56

	/* #222 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554757
	/* java_name */
	.ascii	"java/lang/Integer"
	.zero	74

	/* #223 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554784
	/* java_name */
	.ascii	"java/lang/LinkageError"
	.zero	69

	/* #224 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554758
	/* java_name */
	.ascii	"java/lang/Long"
	.zero	77

	/* #225 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554785
	/* java_name */
	.ascii	"java/lang/NoClassDefFoundError"
	.zero	61

	/* #226 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554786
	/* java_name */
	.ascii	"java/lang/NullPointerException"
	.zero	61

	/* #227 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554787
	/* java_name */
	.ascii	"java/lang/Number"
	.zero	75

	/* #228 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554759
	/* java_name */
	.ascii	"java/lang/Object"
	.zero	75

	/* #229 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554789
	/* java_name */
	.ascii	"java/lang/ReflectiveOperationException"
	.zero	53

	/* #230 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554783
	/* java_name */
	.ascii	"java/lang/Runnable"
	.zero	73

	/* #231 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554760
	/* java_name */
	.ascii	"java/lang/RuntimeException"
	.zero	65

	/* #232 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554761
	/* java_name */
	.ascii	"java/lang/Short"
	.zero	76

	/* #233 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554762
	/* java_name */
	.ascii	"java/lang/String"
	.zero	75

	/* #234 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554764
	/* java_name */
	.ascii	"java/lang/Thread"
	.zero	75

	/* #235 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554766
	/* java_name */
	.ascii	"java/lang/Throwable"
	.zero	72

	/* #236 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554790
	/* java_name */
	.ascii	"java/lang/UnsupportedOperationException"
	.zero	52

	/* #237 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554792
	/* java_name */
	.ascii	"java/lang/annotation/Annotation"
	.zero	60

	/* #238 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554794
	/* java_name */
	.ascii	"java/lang/reflect/AnnotatedElement"
	.zero	57

	/* #239 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554796
	/* java_name */
	.ascii	"java/lang/reflect/GenericDeclaration"
	.zero	55

	/* #240 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554798
	/* java_name */
	.ascii	"java/lang/reflect/Type"
	.zero	69

	/* #241 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554800
	/* java_name */
	.ascii	"java/lang/reflect/TypeVariable"
	.zero	61

	/* #242 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554708
	/* java_name */
	.ascii	"java/net/ProxySelector"
	.zero	69

	/* #243 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554724
	/* java_name */
	.ascii	"java/nio/Buffer"
	.zero	76

	/* #244 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554726
	/* java_name */
	.ascii	"java/nio/ByteBuffer"
	.zero	72

	/* #245 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554731
	/* java_name */
	.ascii	"java/nio/channels/ByteChannel"
	.zero	62

	/* #246 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554733
	/* java_name */
	.ascii	"java/nio/channels/Channel"
	.zero	66

	/* #247 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554728
	/* java_name */
	.ascii	"java/nio/channels/FileChannel"
	.zero	62

	/* #248 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554735
	/* java_name */
	.ascii	"java/nio/channels/GatheringByteChannel"
	.zero	53

	/* #249 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554737
	/* java_name */
	.ascii	"java/nio/channels/InterruptibleChannel"
	.zero	53

	/* #250 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554739
	/* java_name */
	.ascii	"java/nio/channels/ReadableByteChannel"
	.zero	54

	/* #251 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554741
	/* java_name */
	.ascii	"java/nio/channels/ScatteringByteChannel"
	.zero	52

	/* #252 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554743
	/* java_name */
	.ascii	"java/nio/channels/SeekableByteChannel"
	.zero	54

	/* #253 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554745
	/* java_name */
	.ascii	"java/nio/channels/WritableByteChannel"
	.zero	54

	/* #254 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554746
	/* java_name */
	.ascii	"java/nio/channels/spi/AbstractInterruptibleChannel"
	.zero	41

	/* #255 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554712
	/* java_name */
	.ascii	"java/security/KeyStore"
	.zero	69

	/* #256 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554714
	/* java_name */
	.ascii	"java/security/KeyStore$LoadStoreParameter"
	.zero	50

	/* #257 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554716
	/* java_name */
	.ascii	"java/security/KeyStore$ProtectionParameter"
	.zero	49

	/* #258 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554717
	/* java_name */
	.ascii	"java/security/cert/Certificate"
	.zero	61

	/* #259 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554719
	/* java_name */
	.ascii	"java/security/cert/CertificateFactory"
	.zero	54

	/* #260 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554722
	/* java_name */
	.ascii	"java/security/cert/X509Certificate"
	.zero	57

	/* #261 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554721
	/* java_name */
	.ascii	"java/security/cert/X509Extension"
	.zero	59

	/* #262 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554676
	/* java_name */
	.ascii	"java/util/ArrayList"
	.zero	72

	/* #263 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554665
	/* java_name */
	.ascii	"java/util/Collection"
	.zero	71

	/* #264 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554667
	/* java_name */
	.ascii	"java/util/HashMap"
	.zero	74

	/* #265 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554685
	/* java_name */
	.ascii	"java/util/HashSet"
	.zero	74

	/* #266 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554711
	/* java_name */
	.ascii	"java/util/Iterator"
	.zero	73

	/* #267 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554508
	/* java_name */
	.ascii	"javax/net/ssl/TrustManager"
	.zero	65

	/* #268 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554511
	/* java_name */
	.ascii	"javax/net/ssl/TrustManagerFactory"
	.zero	58

	/* #269 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554510
	/* java_name */
	.ascii	"javax/net/ssl/X509TrustManager"
	.zero	61

	/* #270 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554838
	/* java_name */
	.ascii	"mono/android/TypeManager"
	.zero	67

	/* #271 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554661
	/* java_name */
	.ascii	"mono/android/runtime/InputStreamAdapter"
	.zero	52

	/* #272 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	0
	/* java_name */
	.ascii	"mono/android/runtime/JavaArray"
	.zero	61

	/* #273 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554682
	/* java_name */
	.ascii	"mono/android/runtime/JavaObject"
	.zero	60

	/* #274 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554700
	/* java_name */
	.ascii	"mono/android/runtime/OutputStreamAdapter"
	.zero	51

	/* #275 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554521
	/* java_name */
	.ascii	"mono/android/view/View_OnClickListenerImplementor"
	.zero	42

	/* #276 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554583
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_CardReaderStatusListenerImplementor"
	.zero	14

	/* #277 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554589
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_EPassportReaderStatusListenerImplementor"
	.zero	9

	/* #278 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554595
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_FingerprintReaderStatusListenerImplementor"
	.zero	7

	/* #279 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554605
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_GIcaoReadListenerImplementor"
	.zero	21

	/* #280 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554609
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_GNIDReadListenerImplementor"
	.zero	22

	/* #281 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554613
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_ICAODocumentReadListenerImplementor"
	.zero	14

	/* #282 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554618
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_MRZStatusListenerImplementor"
	.zero	21

	/* #283 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554633
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnCCFToFMDConversionListenerImplementor"
	.zero	10

	/* #284 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554622
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnCardCommandListenerImplementor"
	.zero	17

	/* #285 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554625
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnCardCommandSyncResultListenerImplementor"
	.zero	7

	/* #286 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554629
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnCardStatusListenerImplementor"
	.zero	18

	/* #287 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554637
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnCompareFMDListenerImplementor"
	.zero	18

	/* #288 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554641
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnCompressToWSQListenerImplementor"
	.zero	15

	/* #289 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554645
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnConvertToFMDListenerImplementor"
	.zero	16

	/* #290 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554649
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnDecompressWSQListenerImplementor"
	.zero	15

	/* #291 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554657
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnEPassportCommandListenerImplementor"
	.zero	12

	/* #292 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554661
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnEPassportStatusListenerImplementor"
	.zero	13

	/* #293 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554653
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnEktpCardReadListenerImplementor"
	.zero	16

	/* #294 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554689
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnFMDToCCFConversionListenerImplementor"
	.zero	10

	/* #295 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554685
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnFingerQualityListenerImplementor"
	.zero	15

	/* #296 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554666
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnFingerprintGrabbedFullListenerImplementor"
	.zero	6

	/* #297 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554671
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnFingerprintGrabbedListenerImplementor"
	.zero	10

	/* #298 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554676
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnFingerprintGrabbedRawListenerImplementor"
	.zero	7

	/* #299 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554681
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnFingerprintGrabbedWSQListenerImplementor"
	.zero	7

	/* #300 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554693
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnGetFingerQualityListenerImplementor"
	.zero	12

	/* #301 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554697
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnGetProviderDetailsListenerImplementor"
	.zero	10

	/* #302 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554701
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnInitializedListenerImplementor"
	.zero	17

	/* #303 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554706
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnIrisesCapturedListenerImplementor"
	.zero	14

	/* #304 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554714
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnMRZDocumentStatusListenerImplementor"
	.zero	11

	/* #305 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554718
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnMRZReaderListenerImplementor"
	.zero	19

	/* #306 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554710
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnMobileDataChangedListenerImplementor"
	.zero	11

	/* #307 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554723
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_OnMultiFingerprintGrabbedListenerImplementor"
	.zero	5

	/* #308 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554727
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_PreferencesListenerImplementor"
	.zero	19

	/* #309 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554601
	/* java_name */
	.ascii	"mono/com/credenceid/biometrics/Biometrics_generateTerminalIsCertificateListenerImplementor"
	.zero	1

	/* #310 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554524
	/* java_name */
	.ascii	"mono/com/credenceid/face/FaceEngine_OnAnalyzeFaceImageListenerImplementor"
	.zero	18

	/* #311 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554528
	/* java_name */
	.ascii	"mono/com/credenceid/face/FaceEngine_OnCreateFaceTemplateListenerImplementor"
	.zero	16

	/* #312 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554532
	/* java_name */
	.ascii	"mono/com/credenceid/face/FaceEngine_OnDetectFaceListenerImplementor"
	.zero	24

	/* #313 */
	/* module_index */
	.word	1
	/* type_token_id */
	.word	33554536
	/* java_name */
	.ascii	"mono/com/credenceid/face/FaceEngine_OnMatchFaceTemplatesListenerImplementor"
	.zero	16

	/* #314 */
	/* module_index */
	.word	2
	/* type_token_id */
	.word	33554765
	/* java_name */
	.ascii	"mono/java/lang/RunnableImplementor"
	.zero	57

	.size	map_java, 31185
/* Java to managed map: END */

