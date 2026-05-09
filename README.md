# Abstração de Celular — POO em C#

Solução para o desafio de **Programação Orientada a Objetos** do bootcamp da [DIO (Digital Innovation One)](https://www.dio.me/), implementado em C#.

O projeto modela um sistema de celulares utilizando **classe abstrata**, **herança** e **polimorfismo**, permitindo que Nokia e iPhone tenham comportamentos distintos ao instalar aplicativos.

## Conceitos Aplicados

| Conceito | Aplicação no projeto |
|---|---|
| Classe abstrata | `Smartphone` — define o contrato base, não pode ser instanciada diretamente |
| Herança | `Nokia` e `Iphone` herdam de `Smartphone` |
| Polimorfismo (override) | `InstalarAplicativo()` possui implementação específica em cada subclasse |
| Encapsulamento | Propriedades do celular (número, modelo, IMEI, memória) acessadas de forma controlada |

## Hierarquia de Classes

```
Smartphone (abstract)
├── Nokia
└── Iphone
```

## Estrutura do Projeto

```
AbstracaoCelular/
├── Models/
│   ├── Smartphone.cs   # Classe abstrata base
│   ├── Nokia.cs        # Implementação Nokia com override de InstalarAplicativo
│   └── Iphone.cs       # Implementação iPhone com override de InstalarAplicativo
└── Program.cs          # Demonstração do comportamento polimórfico
```

## Exemplo de Uso

```csharp
Nokia nokia = new Nokia("78481", "Plus 5g", "9q482", 4);
Iphone iphone = new Iphone("1398882912", "16 PRO MAX", "0067", 8);

nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

iphone.Ligar();
iphone.InstalarAplicativo("Clash Royale");
```

**Saída esperada:**
```
Ligando...
Instalando o aplicativo Whatsapp na loja Nokia.
Ligando...
Instalando o aplicativo Clash Royale na App Store.
```

## Como Executar

**Pré-requisito:** [.NET SDK](https://dotnet.microsoft.com/download) instalado.

```bash
git clone https://github.com/gaspudo/AbstracaoCelular.git
cd AbstracaoCelular
dotnet run
```

## Contexto

Desafio proposto pela DIO na trilha de .NET com C#, com o objetivo de fixar os pilares da OOP por meio de um modelo de domínio simples e concreto.
