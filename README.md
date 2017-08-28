# Mailer

Simple commandline utility for sending email written in C#

## List available parameters

```bash
$> mailer.exe -help
```

## Sending emal

```bash
$> mailer.exe -to "my@email.domain" -from "recipient@email.domain" -subject "Hello World!" -body "Hello World message" -user "my@email.domain" -password "pa$$word" -server "smtp.mail.server" -port 25
```

## Credits

(C) Martin Kukolos

This application using [Command Line Parser](http://cmdline.codeplex.com)

## License

This application GNU GPLv3
Command Line Parser GNU GPLv2
