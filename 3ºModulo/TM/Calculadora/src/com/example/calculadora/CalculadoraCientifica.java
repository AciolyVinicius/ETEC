package com.example.calculadora;

import com.example.calculadora.*;

import java.lang.Math;
import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;


public class CalculadoraCientifica extends Activity {

	EditText num1, num2, num3;
	double n1, n2, n3, result;
	int n;
	int nn, nn2, nn3;
	TextView resultado;
	
    @Override
    protected void onCreate(Bundle savedInstanceState) { 	
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_calculadora_cientifica);        
        
        resultado = (TextView) findViewById(R.id.txtResultado);
        
        Button btnDiv = (Button)findViewById(R.id.btnDivisao);
		Button btnExp = (Button)findViewById(R.id.btnExponencial);
		Button btnRoot = (Button)findViewById(R.id.btnRaiz);
		Button btnFat = (Button)findViewById(R.id.btnFatorial);
		Button btnFib = (Button)findViewById(R.id.btnFibonacci);
		Button btnSen = (Button)findViewById(R.id.btnSeno);
		Button btnCos = (Button)findViewById(R.id.btnCosseno);
		Button btnTan = (Button)findViewById(R.id.btnTangente);
        Button btnLog = (Button)findViewById(R.id.btnLogaritimo);
        Button btnBhas = (Button)findViewById(R.id.btnBhaskara);

		num1 = (EditText)findViewById(R.id.txt_num1);
		num2 = (EditText)findViewById(R.id.txt_num2);
		num3 = (EditText)findViewById(R.id.txt_num3);
        
		final String nm1, nm2, nm3;
		nm1 = num1.getText().toString();
		nm2 = num2.getText().toString();
		nm3 = num3.getText().toString();
		
        btnDiv.setOnClickListener(new OnClickListener() {
			@Override
			public void onClick(View arg0) {
				if (nm1 != "" && nm2 != "" && nm1 != null && nm2 != null){
				n1 = Double.parseDouble(num1.getText().toString());
				n2 = Double.parseDouble(num2.getText().toString());
				result = n1 * Math.pow(n2, -1);
				
				resultado.setText(""+result);
			}
			}
        });
		
        btnExp.setOnClickListener(new OnClickListener() {
			@Override
			public void onClick(View arg0) {
				if (nm1 != "" && nm2 != ""&& nm1 != null && nm2 != null){
				n1 = Double.parseDouble(num1.getText().toString());
				n2 = Double.parseDouble(num2.getText().toString());
				result = Math.pow(n1, n2);
				
				resultado.setText(""+result);
			}
			}
        });
		
        btnRoot.setOnClickListener(new OnClickListener() {
			@Override
			public void onClick(View arg0) {
				if (nm1 != "" && nm2 != "" && nm1 != null && nm2 != null){
				n1 = Double.parseDouble(num1.getText().toString());
				n2 = Double.parseDouble(num2.getText().toString());
				result = Math.pow(n2,(1/n1));
				
				resultado.setText(""+result);
			}
			}
        });
		
        btnFat.setOnClickListener(new OnClickListener() {
			@Override
			public void onClick(View arg0) {
				if (nm1 != "" && nm1 != null){
				n = Integer.parseInt(num1.getText().toString());
				int countfat = 1, atual=1;
				do{
					atual = countfat * atual;
					countfat++;
				}
				while(countfat<=n);
				
				result = Double.parseDouble(""+atual);
				
				resultado.setText(""+result);
			}
			}
        });
        	
        btnFib.setOnClickListener(new OnClickListener() {
			@Override
			public void onClick(View arg0) {
				if (nm1 != "" && nm1 != null){
				String fibo = "1 ";
				n = Integer.parseInt(num1.getText().toString());
				n = n - 1;
				int countfib = 1, anteriorfib = 0, at = 1, res;
				do{					
					if (n < 0){
						break;
					}
					res = anteriorfib + at;
					fibo = fibo + "- " + res + " "; 
					anteriorfib = at;
					at = res;
					
					
					countfib++;
				}
				while(countfib<=n);
				
				resultado.setText(""+fibo);
			}}
        });
		
        btnSen.setOnClickListener(new OnClickListener() {
			@Override
			public void onClick(View arg0) {
				if (nm1 != "" && nm1 != null){
				n = Integer.parseInt(num1.getText().toString());
				
				result = Math.toRadians(n);
				result = Math.sin(result);
				
				resultado.setText(""+result);
			}
			}
        });
		
        btnCos.setOnClickListener(new OnClickListener() {
			@Override
			public void onClick(View arg0) {
				if (nm1 != "" && nm1 != null){
				n = Integer.parseInt(num1.getText().toString());
				
				result = Math.toRadians(n);
				result = Math.cos(result);
				
				resultado.setText(""+result);
			}
			}
        });
		
        btnTan.setOnClickListener(new OnClickListener() {
			@Override
			public void onClick(View arg0) {
				if (nm1 != "" && nm2 != "" && nm1 != null && nm2 != null){
				n = Integer.parseInt(num1.getText().toString());
				
				result = Math.toRadians(n);
				result = Math.tan(result);
				
				resultado.setText(""+result);
			}
			}
        });
        
        btnLog.setOnClickListener(new OnClickListener() {
			@Override
			public void onClick(View arg0) {
				if (nm1 != "" && nm2 != "" && nm1 != null && nm2 != null){
				nn = Integer.parseInt(num1.getText().toString());
				nn2 = Integer.parseInt(num2.getText().toString());
				
				result = (Math.log(nn)/Math.log(nn2));
				
				resultado.setText(""+result);
			}
			}
        });
        
        btnBhas.setOnClickListener(new OnClickListener() {
			@Override
			public void onClick(View arg0) {
				if (nm1 != "" && nm2 != "" && nm3 != "" && nm1 != null && nm2 != null && nm3 != null){
				nn = Integer.parseInt(num1.getText().toString());
				nn2 = Integer.parseInt(num2.getText().toString());
				nn3 = Integer.parseInt(num3.getText().toString());
				
				Double x1, x2;
				
				result = Math.pow(n2, 2) - (4*nn*nn3);
				if (result>0){
				x1 = ((-nn2)-Math.pow(result, 1/2))/(2*nn);
				x2 = ((-nn2)+Math.pow(result, 1/2))/(2*nn);
				
				resultado.setText("x1 = "+x1+" | x2 = "+ x2);
				}
				else{
					resultado.setText("Delta é menor que 0");
				}
			}
			}
        });
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.calculadora_cientifica, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();
        if (id == R.id.action_settings) {
            return true;
        }
        return super.onOptionsItemSelected(item);
    }
}
