// Dados fictícios de produção (em toneladas)
const productionData = [
    { food: 'Milho', value: Math.floor(Math.random() * 200) + 50 },
    { food: 'Arroz', value: Math.floor(Math.random() * 200) + 50 },
    { food: 'Cevada', value: Math.floor(Math.random() * 200) + 50 }
];

// Função para gerar o gráfico
const barChartContainer = document.getElementById('bar-chart');
productionData.forEach(data => {
    const bar = document.createElement('div');
    bar.className = 'bar';
    bar.style.height = data.value + 'px';
    bar.textContent = `${data.food} (${data.value} t)`;
    barChartContainer.appendChild(bar);
});

// gerar dados aleatorios para os gráficos
const simulatedData = [
    Math.floor(Math.random() * 200) + 50, 
    Math.floor(Math.random() * 200) + 50,  
    Math.floor(Math.random() * 200) + 50
];


//============================================================


function calcularMedias(dados) {
    const totalMeses = dados.length;
    let somaProducao = 0, somaPerdas = 0, somaLucro = 0;

    dados.forEach(dado => {
        somaProducao += dado.producao;
        somaPerdas += dado.perdas;
        somaLucro += dado.lucro;
    }); 

    return {
        mediaProducao: (somaProducao / totalMeses).toFixed(2),
        mediaPerdas: (somaPerdas / totalMeses).toFixed(2),
        mediaLucro: ((somaLucro / totalMeses) * 23.79 ).toFixed(2),
        // Ganhos como lucro + perdas, contando o valor do produto vendido
        mediaGanhos: ((somaLucro + somaPerdas) / totalMeses).toFixed(2) 
    };
}

function exibirMedias(medias) {
    document.getElementById("mediaProducao").textContent = `${medias.mediaProducao} t`;
    document.getElementById("mediaPerdas").textContent = `${medias.mediaPerdas} Kg`;
    document.getElementById("mediaLucro").textContent = `R$ ${medias.mediaLucro}`;
    document.getElementById("mediaGanhos").textContent = `R$ ${medias.mediaGanhos}`;

    if (mediaLucro >= 35000.00) {
        document.getElementById("res").textContent = "ÓTIMO";
        document.getElementById("res").style.color = "green";
    } else if (mediaLucro <= 27000.00) {
        document.getElementById("res").textContent = "RUIM";
        document.getElementById("res").style.color = "red";
    } else {
        document.getElementById("res").textContent = "REGULAR";
        document.getElementById("res").style.color = "orange";
    }
}


// Gera dados para 12 meses e calcula as médias
const dadosSimulados = gerarDadosSimulados(12);
const medias = calcularMedias(dadosSimulados);
exibirMedias(medias);


//============================================================






// Configuração dos dados para o gráfico
const data = {
    labels: ['Arroz', 'Cevada', 'Milho'],
    datasets: [{
        data: simulatedData, // Usa os valores simulados
        backgroundColor: ['#4A5D73', '#7A8C9A', '#2E4057'],
        borderColor: '#ffffff',
        borderWidth: 2
    }]
};

// Configuração do gráfico
const config = {
    type: 'pie',
    data: data,
    options: {
        responsive: true,
        plugins: {
            legend: {
                position: 'top'
            },
            tooltip: {
                callbacks: {
                    label: function(context) {
                        let label = context.label || '';
                        if (label) {
                            label += ': ';
                        }
                        label += context.raw + ' t';
                        return label;
                    }
                }
            }
        }
    }
};

// Inicialização do gráfico
const myPieChart = new Chart(
    document.getElementById('myPieChart'),
    config
);
